using ScintillaNET;

namespace EasyScintilla.Stylers
{
    public abstract class ScintillaStyler
    {
        private Lexer _lexer;
        private bool _showLineNumbers;
        private bool _codeFolding;
        private bool _braceMatching;
        private bool _autoIndent;

        protected ScintillaStyler(Lexer lex) : this(lex, true, true, true, true)
        {}

        protected ScintillaStyler(Lexer lex, bool lineNumbers, bool codeFolding, bool braceMatching, bool autoIndent)
        {
            _lexer = lex;
            _showLineNumbers = lineNumbers;
            _codeFolding = codeFolding;
            _braceMatching = braceMatching;
            _autoIndent = autoIndent;
        }

        public abstract void ApplyStyle(ScintillaNET.Scintilla scintilla);
        public abstract void RemoveStyle(ScintillaNET.Scintilla scintilla);
        public abstract void SetKeywords(ScintillaNET.Scintilla scintilla);

        public virtual Lexer Lexer
        {
            get { return _lexer; }
            set { _lexer = value; }
        }

        public virtual bool ShowLineNumbers
        {
            get { return _showLineNumbers; }
            set { _showLineNumbers = value; }
        }

        public virtual bool CodeFolding
        {
            get { return _codeFolding; }
            set { _codeFolding = value; }
        }

        public virtual bool BraceMatching
        {
            get { return _braceMatching; }
            set { _braceMatching = value; }
        }

        public virtual bool AutoIndent
        {
            get { return _autoIndent; }
            set { _autoIndent = value; }
        }

        public virtual bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '<':
                case '>':
                    return true;
            }

            return false;
        }

        public virtual char IndentChar { get { return '{'; } }
        public virtual char OutdentChar { get { return '}'; } }
    }
}
