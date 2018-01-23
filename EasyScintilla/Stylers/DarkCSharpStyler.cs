using System.Drawing;
using ScintillaNET;

namespace EasyScintilla.Stylers
{
    /// <summary>
    /// C# styler for a dark UI
    /// </summary>
    public class DarkCSharpStyler : CSharpStyler
    {
        private Color _backupCaretForeColor;

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            var backColor = Color.FromArgb(30, 30, 30);
            var foreColor = Color.FromArgb(220, 220, 220);

            foreach (var style in scintilla.Styles)
                style.BackColor = backColor;

            // Configure the CPP (C#) lexer styles
            scintilla.Styles[Style.Cpp.Identifier].ForeColor = Color.FromArgb(220, 220, 220);
            scintilla.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(59, 170, 57); // Green
            scintilla.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(59, 170, 57); // Green
            scintilla.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(59, 170, 57); // Green
            scintilla.Styles[Style.Cpp.Number].ForeColor = Color.FromArgb(223, 255, 206); // Bright Green (nearly White)
            scintilla.Styles[Style.Cpp.Word].ForeColor = Color.FromArgb(93, 168, 230); // Blue
            scintilla.Styles[Style.Cpp.Word2].ForeColor = Color.FromArgb(71, 200, 185); // Turqoise
            scintilla.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(252, 156, 108); // Red
            scintilla.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(252, 156, 108); // Red
            scintilla.Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(252, 156, 108); // Red
            scintilla.Styles[Style.Cpp.StringEol].BackColor = Color.FromArgb(200, 130, 130); // Dark Red
            scintilla.Styles[Style.Cpp.Operator].ForeColor =
                Color.FromArgb(200, 230, 255); // Bright Blue (nearly White)
            scintilla.Styles[Style.Cpp.Preprocessor].ForeColor = Color.FromArgb(146, 206, 255); // Bright Blue

            scintilla.Styles[Style.IndentGuide].ForeColor = Color.FromArgb(105, 105, 105);
            scintilla.Styles[Style.LineNumber].ForeColor = Color.FromArgb(146, 206, 255); // Bright Blue

            _backupCaretForeColor = scintilla.CaretForeColor;
            scintilla.CaretForeColor = Color.FromArgb(220, 220, 220);

            scintilla.SetFoldMarginHighlightColor(true, backColor);
            scintilla.SetFoldMarginColor(true, backColor);

            scintilla.SetSelectionBackColor(true, Color.FromArgb(38, 79, 120));
        }

        public override void RemoveStyle(Scintilla scintilla)
        {
            base.RemoveStyle(scintilla);

            scintilla.CaretForeColor = _backupCaretForeColor;

            scintilla.SetFoldMarginColor(false, Color.Empty);
            scintilla.SetFoldMarginHighlightColor(false, Color.Empty);

            scintilla.SetSelectionBackColor(true, Color.Silver);
        }
    }
}