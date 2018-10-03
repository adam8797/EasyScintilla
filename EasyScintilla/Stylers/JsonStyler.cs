using System.Drawing;
using ScintillaNET;

namespace EasyScintilla.Stylers
{
    public class JsonStyler : ScintillaStyler
    {
        public JsonStyler() : base(Lexer.Json)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            scintilla.Styles[Style.Json.Default].ForeColor = Color.Silver;
            scintilla.Styles[Style.Json.BlockComment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintilla.Styles[Style.Json.LineComment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintilla.Styles[Style.Json.Number].ForeColor = Color.Olive;
            scintilla.Styles[Style.Json.PropertyName].ForeColor = Color.Blue;
            scintilla.Styles[Style.Json.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintilla.Styles[Style.Json.StringEol].BackColor = Color.Pink;
            scintilla.Styles[Style.Json.Operator].ForeColor = Color.Purple;
        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
        }
    }
}