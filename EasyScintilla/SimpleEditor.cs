using System;
using System.Drawing;
using System.Text.RegularExpressions;
using EasyScintilla.Stylers;
using ScintillaNET;

namespace EasyScintilla
{
    public sealed class SimpleEditor : ScintillaNET.Scintilla
    {
        public SimpleEditor()
        {
            _styler = null;
        }

        #region Private Fields
        private int _maxLineNumberCharLength;
        private int _lastCaretPos = 0;
        private ScintillaStyler _styler;
        #endregion

        #region Private Methods
        private void Reset()
        {
            StyleResetDefault();
            Styles[Style.Default].Font = "consolas";
            Styles[Style.Default].Size = 10;
            StyleClearAll();

            if (_styler != null)
                _styler.RemoveStyle(this);

            SetKeywords(0, "");
            SetKeywords(1, "");
            SetKeywords(2, "");
            SetKeywords(3, "");
            SetKeywords(4, "");

            //Some base styles
            IndentationGuides = IndentView.LookBoth;
            Styles[Style.BraceLight].BackColor = Color.LightGray;
            Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            Styles[Style.BraceBad].ForeColor = Color.Red;

        }
        #endregion

        #region Public Properties
        public ScintillaStyler Styler
        {
            get { return _styler; }
            set
            {
                Reset();

                _styler = value;

                if (_styler == null)
                {
                    SetCodeFolding(false);
                    SetLineNumbering(false);
                    SetBraceMatching(false);
                    SetAutoIndent(false);
                }
                else
                {
                    Lexer = _styler.Lexer;

                    SetCodeFolding(_styler.CodeFolding);
                    SetLineNumbering(_styler.ShowLineNumbers);
                    SetBraceMatching(_styler.BraceMatching);
                    SetAutoIndent(_styler.AutoIndent);

                    _styler.ApplyStyle(this);

                    _styler.SetKeywords(this);
                }
            }
        }
        #endregion

        #region Public Methods
        public void SetCodeFolding(bool enabled)
        {
            if (enabled)
            {
                _styler.ApplyCodeFoldingOptions(this, enabled);

                // Use margin 2 for fold markers
                Margins[2].Type = MarginType.Symbol;
                Margins[2].Mask = Marker.MaskFolders;
                Margins[2].Sensitive = true;
                Margins[2].Width = 20;

                // Reset folder markers
                for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
                {
                    Markers[i].SetForeColor(SystemColors.ControlLightLight);
                    Markers[i].SetBackColor(SystemColors.ControlDark);
                }

                // Style the folder markers
                Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
                Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
                Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
                Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
                Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
                Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
                Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
                Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
                Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

                // Enable automatic folding
                AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
            }
            else
            {
                _styler?.ApplyCodeFoldingOptions(this, enabled);
                Margins[2].Width = 0;
            }
        }

        public void SetLineNumbering(bool enabled)
        {
            if (enabled)
            {
                Margins[0].Width = 24;
                TextChanged += LineNumbers_TextChanged;
            }
            else
            {
                Margins[0].Width = 0;
                TextChanged -= LineNumbers_TextChanged;
            }
        }

        public void SetBraceMatching(bool enabled)
        {
            if (enabled)
            {
                UpdateUI += BraceMatching_UpdateUI;
            }
            else
            {
                UpdateUI -= BraceMatching_UpdateUI;
            }
        }

        public void SetAutoIndent(bool enabled)
        {
            if (enabled)
            {
                InsertCheck += AutoIndent_InsertCheck;
                CharAdded += AutoIndent_CharAdded;
            }
            else
            {
                InsertCheck -= AutoIndent_InsertCheck;
                CharAdded -= AutoIndent_CharAdded;
            }
        }
        #endregion

        #region Event Handlers
        //Line Numbers
        private void LineNumbers_TextChanged(object sender, EventArgs e)
        {
            var maxLineNumberCharLength = Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == _maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            Margins[0].Width = TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            _maxLineNumberCharLength = maxLineNumberCharLength;
        }

        //Brace Matching
        private void BraceMatching_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            if (_styler != null && _styler.BraceMatching)
            {
                var caretPos = CurrentPosition;
                if (_lastCaretPos != caretPos)
                {
                    _lastCaretPos = caretPos;
                    var bracePos1 = -1;

                    // Is there a brace to the left or right?
                    if (caretPos > 0 && _styler.IsBrace(GetCharAt(caretPos - 1)))
                        bracePos1 = (caretPos - 1);
                    else if (_styler.IsBrace(GetCharAt(caretPos)))
                        bracePos1 = caretPos;

                    if (bracePos1 >= 0)
                    {
                        // Find the matching brace
                        var bracePos2 = BraceMatch(bracePos1);
                        if (bracePos2 == ScintillaNET.Scintilla.InvalidPosition)
                            BraceBadLight(bracePos1);
                        else
                            BraceHighlight(bracePos1, bracePos2);
                    }
                    else
                    {
                        // Turn off brace matching
                        BraceHighlight(ScintillaNET.Scintilla.InvalidPosition, ScintillaNET.Scintilla.InvalidPosition);
                    }
                }
            }
        }


        //Auto Indent
        private void AutoIndent_InsertCheck(object sender, InsertCheckEventArgs e)
        {
            if (_styler != null)
            {
                if (e.Text.EndsWith("\r") || e.Text.EndsWith("\n"))
                {
                    int startPos = Lines[LineFromPosition(CurrentPosition)].Position;
                    int endPos = e.Position;
                    string curLineText = GetTextRange(startPos, (endPos - startPos));
                        //Text until the caret so that the whitespace is always equal in every line.

                    Match indent = Regex.Match(curLineText, "^[ \\t]*");
                    e.Text = (e.Text + indent.Value);
                    if (Regex.IsMatch(curLineText, _styler.IndentChar + "\\s*$"))
                    {
                        e.Text = (e.Text + "    ");
                    }
                }
            }
        }


        //Auto Indent
        private void AutoIndent_CharAdded(object sender, CharAddedEventArgs e)
        {
            if (_styler != null)
            {
                if (_styler.IndentChar == e.Char)
                {
                    int curLine = LineFromPosition(CurrentPosition);

                    if (Lines[curLine].Text.Trim() == "}")
                    {
                        //Check whether the bracket is the only thing on the line.. For cases like "if() { }".
                        SetIndent(curLine, GetIndent(curLine) - 4);
                    }
                }
                else if (_styler.OutdentChar == e.Char)
                {
                    int curLine = LineFromPosition(CurrentPosition);

                    if (Lines[curLine].Text.Trim() == "" + _styler.OutdentChar)
                    {
                        SetIndent(curLine, GetIndent(curLine) - 4);
                    }
                }
            }
        }
        #endregion

        //Codes for the handling the Indention of the lines.
        //They are manually added here until they get officially added to the Scintilla control.
        #region "CodeIndent Handlers"
        const int SCI_SETLINEINDENTATION = 2126;
        const int SCI_GETLINEINDENTATION = 2127;
        private void SetIndent(int line, int indent)
        {
            DirectMessage(SCI_SETLINEINDENTATION, new IntPtr(line), new IntPtr(indent));
        }
        private int GetIndent(int line)
        {
            return (DirectMessage(SCI_GETLINEINDENTATION, new IntPtr(line), IntPtr.Zero).ToInt32());
        }
        #endregion
    }
}
