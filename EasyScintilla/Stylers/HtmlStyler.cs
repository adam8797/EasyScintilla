using System.Drawing;
using ScintillaNET;

namespace EasyScintilla.Stylers
{
    public class HtmlStyler : ScintillaStyler
    {
        public HtmlStyler() : base(Lexer.Html)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            scintilla.Styles[Style.Html.Default].ForeColor = Color.Black;
            scintilla.Styles[Style.Html.Default].BackColor = Color.White;

            scintilla.Styles[Style.Html.Comment].ForeColor = ColorTranslator.FromHtml("#008000");
            scintilla.Styles[Style.Html.Comment].BackColor = Color.White;

            scintilla.Styles[Style.Html.Number].ForeColor = Color.Red;
            scintilla.Styles[Style.Html.Number].BackColor = Color.White;

            scintilla.Styles[Style.Html.DoubleString].ForeColor = ColorTranslator.FromHtml("#8000FF");
            scintilla.Styles[Style.Html.DoubleString].BackColor = Color.White;

            scintilla.Styles[Style.Html.SingleString].ForeColor = ColorTranslator.FromHtml("#8000FF");
            scintilla.Styles[Style.Html.SingleString].BackColor = Color.White;

            scintilla.Styles[Style.Html.Tag].ForeColor = Color.Blue;
            scintilla.Styles[Style.Html.Tag].BackColor = Color.White;

            scintilla.Styles[Style.Html.TagEnd].ForeColor = Color.Blue;
            scintilla.Styles[Style.Html.TagEnd].BackColor = Color.White;

            scintilla.Styles[Style.Html.TagUnknown].ForeColor = Color.Black;
            scintilla.Styles[Style.Html.TagUnknown].BackColor = Color.White;

            scintilla.Styles[Style.Html.Attribute].ForeColor = Color.Red;
            scintilla.Styles[Style.Html.Attribute].BackColor = Color.White;

            scintilla.Styles[Style.Html.AttributeUnknown].ForeColor = Color.Black;
            scintilla.Styles[Style.Html.AttributeUnknown].BackColor = Color.White;

            scintilla.Styles[21].ForeColor = Color.Black;
            scintilla.Styles[21].BackColor = ColorTranslator.FromHtml("#A6CAF0");

            scintilla.Styles[Style.Html.CData].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[Style.Html.CData].BackColor = Color.White;

            scintilla.Styles[Style.Html.Value].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[Style.Html.Value].BackColor = ColorTranslator.FromHtml("#FEFDE0");

            scintilla.Styles[Style.Html.Entity].ForeColor = Color.Black;
            scintilla.Styles[Style.Html.Entity].BackColor = ColorTranslator.FromHtml("#FEFDE0");

        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
            scintilla.SetKeywords(0,
                "!doctype a abbr accept accept-charset accesskey acronym action address align alink alt applet archive " +
                "area article aside audio axis b background base basefont bdi bdo bgsound bgcolor big blink blockquote " +
                "body border br button canvas caption cellpadding cellspacing center char charoff charset checkbox checked " +
                "cite class classid clear code codebase codetype col colgroup color cols colspan command compact content " +
                "contenteditable contextmenu coords data datafld dataformatas datalist datapagesize datasrc datetime dd " +
                "declare defer del details dfn dialog dir disabled div dl draggable dropzone dt element em embed enctype " +
                "event face fieldset figcaption figure file font footer for form frame frameborder frameset h1 h2 h3 h4 h5 h6 " +
                "head header height hgroup hidden hr href hreflang hspace html http-equiv i id iframe image img input ins isindex " +
                "ismap kbd keygen label lang language leftmargin legend li link listing longdesc main map marginheight marginwidth " +
                "mark marquee maxlength media menu menuitem meta meter multicol method multiple name nav nobr noembed noframes nohref " +
                "noresize noscript noshade nowrap object ol onabort onautocomplete onautocompleteerror onafterprint onbeforeonload " +
                "onbeforeprint onblur oncancel oncanplay oncanplaythrough onchange onclick onclose oncontextmenu oncuechange " +
                "ondblclick ondrag ondragend ondragenter ondragleave ondragover ondragstart ondrop ondurationchange onemptied " +
                "onended onerror onfocus onhashchange oninput oninvalid onkeydown onkeypress onkeyup onload onloadeddata " +
                "onloadedmetadata onloadstart onmessage onmousedown onmouseenter onmouseleave onmousemove onmouseout onmouseover " +
                "onmouseup onmousewheel onoffline ononline onpagehide onpageshow onpause onplay onplaying onpointercancel onpointerdown " +
                "onpointerenter onpointerleave onpointerlockchange onpointerlockerror onpointermove onpointerout onpointerover " +
                "onpointerup onpopstate onprogress onratechange onreadystatechange onredo onreset onresize onscroll onseeked onseeking " +
                "onselect onshow onsort onselect onstalled onstorage onsubmit onsuspend ontimeupdate ontoggle onundo onunload " +
                "onvolumechange onwaiting optgroup option output p param picture plaintext password placeholder pre profile progress " +
                "prompt public q radio readonly rel reset rev rows rowspan rp rt rtc ruby rules s samp scheme scope script section " +
                "select shadow selected shape size small source spacer span spellcheck src standby start strike strong style sub submit " +
                "summary sup svg svg:svg tabindex table target tbody td template text textarea tfoot th thead time title topmargin " +
                "tr track tt type u ul usemap valign value valuetype var version video vlink vspace wbr xmp width xml xmlns");
        }
    }
}
