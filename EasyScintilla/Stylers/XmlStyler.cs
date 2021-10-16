using System.Drawing;
using ScintillaNET;

namespace EasyScintilla.Stylers
{
    public class XmlStyler : ScintillaStyler
    {
        public static XmlStyler XmlStandard
            => new XmlStyler();

        public static XmlStyler XmlWithCodeFolding
            => new XmlStyler(true, false);

        public static XmlStyler XmlWithLineNumbers
            => new XmlStyler(false, true);

        public static XmlStyler XmlWithLineNumbersAndCodeFolding
            => new XmlStyler(true, true);


        public XmlStyler() 
            : this(false, false)
        {
        }

        private XmlStyler(bool useCodFolding, bool lineNumbers)
            : base(Lexer.Html, lineNumbers, useCodFolding, false, false)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            scintilla.Styles[Style.Xml.Default].ForeColor = Color.Black;
            scintilla.Styles[Style.Xml.Default].BackColor = Color.White;

            scintilla.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            scintilla.Styles[Style.Xml.Comment].BackColor = Color.White;

            scintilla.Styles[Style.Xml.Number].ForeColor = Color.Red;
            scintilla.Styles[Style.Xml.Number].BackColor = Color.White;

            scintilla.Styles[Style.Xml.DoubleString].ForeColor = Color.DarkViolet;
            scintilla.Styles[Style.Xml.DoubleString].BackColor = Color.White;

            scintilla.Styles[Style.Xml.SingleString].ForeColor = Color.Violet;
            scintilla.Styles[Style.Xml.SingleString].BackColor = Color.White;

            scintilla.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.Tag].BackColor = Color.White;

            scintilla.Styles[Style.Xml.TagEnd].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.TagEnd].BackColor = Color.White;

            scintilla.Styles[Style.Xml.TagUnknown].ForeColor = Color.Black;
            scintilla.Styles[Style.Xml.TagUnknown].BackColor = Color.White;

            scintilla.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            scintilla.Styles[Style.Xml.Attribute].BackColor = Color.White;

            scintilla.Styles[Style.Xml.AttributeUnknown].ForeColor = Color.Black;
            scintilla.Styles[Style.Xml.AttributeUnknown].BackColor = Color.White;

            scintilla.Styles[Style.Xml.CData].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[Style.Xml.CData].BackColor = Color.White;

            scintilla.Styles[Style.Xml.Value].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[Style.Xml.Value].BackColor = ColorTranslator.FromHtml("#FEFDE0");

            scintilla.Styles[Style.Xml.Entity].ForeColor = Color.Black;
            scintilla.Styles[Style.Xml.Entity].BackColor = ColorTranslator.FromHtml("#FEFDE0");
        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void ApplyCodeFoldingOptions(Scintilla scintilla, bool enableCodeFolding)
        {
            base.ApplyCodeFoldingOptions(scintilla, enableCodeFolding);
            scintilla.SetProperty("fold.html", enableCodeFolding ? "1" : "0");
            //scintilla.SetProperty("fold.compact", "1");   // TODO: check what it does really...
            scintilla.SetProperty("fold.xml.at.tag.open", enableCodeFolding ? "1" : "0");
            scintilla.SetProperty("fold.hypertext.comment", enableCodeFolding ? "1" : "0");
        }

    }
}
