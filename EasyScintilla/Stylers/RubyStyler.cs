using System.Drawing;
using ScintillaNET;

namespace EasyScintilla.Stylers
{
    public class RubyStyler : ScintillaStyler
    {
        public RubyStyler() : base(Lexer.Ruby)
        {
            
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            scintilla.Styles[Style.Ruby.Default].ForeColor = Color.Black;
            scintilla.Styles[Style.Ruby.Default].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Error].ForeColor = Color.Black;
            scintilla.Styles[Style.Ruby.Error].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.CommentLine].ForeColor = ColorTranslator.FromHtml("#008000");
            scintilla.Styles[Style.Ruby.CommentLine].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Pod].ForeColor = ColorTranslator.FromHtml("#004000");
            scintilla.Styles[Style.Ruby.Pod].BackColor = ColorTranslator.FromHtml("#C0FFC0");

            scintilla.Styles[Style.Ruby.Number].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[Style.Ruby.Number].BackColor = Color.White;

            scintilla.Styles[5].ForeColor = Color.Blue;
            scintilla.Styles[5].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.String].ForeColor = ColorTranslator.FromHtml("#808080");
            scintilla.Styles[Style.Ruby.String].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Character].ForeColor = ColorTranslator.FromHtml("#808000");
            scintilla.Styles[Style.Ruby.Character].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.ClassName].ForeColor = ColorTranslator.FromHtml("#0080C0");
            scintilla.Styles[Style.Ruby.ClassName].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.DefName].ForeColor = ColorTranslator.FromHtml("#8080FF");
            scintilla.Styles[Style.Ruby.DefName].BackColor = ColorTranslator.FromHtml("#FFFFCC");

            scintilla.Styles[Style.Ruby.Operator].ForeColor = ColorTranslator.FromHtml("#000080");
            scintilla.Styles[Style.Ruby.Operator].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Identifier].ForeColor = Color.Black;
            scintilla.Styles[Style.Ruby.Identifier].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Regex].ForeColor = ColorTranslator.FromHtml("#0080FF");
            scintilla.Styles[Style.Ruby.Regex].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Global].ForeColor = ColorTranslator.FromHtml("#000080");
            scintilla.Styles[Style.Ruby.Global].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.Symbol].ForeColor = Color.Black;
            scintilla.Styles[Style.Ruby.Symbol].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.ModuleName].ForeColor = ColorTranslator.FromHtml("#804000");
            scintilla.Styles[Style.Ruby.ModuleName].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.InstanceVar].ForeColor = Color.Black;
            scintilla.Styles[Style.Ruby.InstanceVar].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.ClassVar].ForeColor = Color.Black;
            scintilla.Styles[Style.Ruby.ClassVar].BackColor = Color.White;

            scintilla.Styles[Style.Ruby.BackTicks].ForeColor = ColorTranslator.FromHtml("#FFFF00");
            scintilla.Styles[Style.Ruby.BackTicks].BackColor = ColorTranslator.FromHtml("#A08080");

            scintilla.Styles[Style.Ruby.DataSection].ForeColor = ColorTranslator.FromHtml("#600000");
            scintilla.Styles[Style.Ruby.DataSection].BackColor = ColorTranslator.FromHtml("#FFF0D8");

            scintilla.Styles[Style.Ruby.StringQ].ForeColor = ColorTranslator.FromHtml("#808080");
            scintilla.Styles[Style.Ruby.StringQ].BackColor = Color.White;
        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
            
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
            scintilla.SetKeywords(0,
                "ARGF ARGV BEGIN END ENV FALSE DATA NIL RUBY_PATCHLEVEL RUBY_PLATFORM RUBY_RELEASE_DATE RUBY_VERSION " +
                "PLATFORM RELEASE_DATE STDERR STDIN STDOUT TOPLEVEL_BINDING TRUE __ENCODING__ __END__ __FILE__ __LINE__ " +
                "alias and begin break case class def defined? do else elsif end ensure false for if in module next nil " +
                "not or redo rescue retry return self super then true undef unless until when while yield");
        }
    }
}
