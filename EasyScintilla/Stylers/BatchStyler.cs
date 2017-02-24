using System.Drawing;
using ScintillaNET;

namespace ScintillaWrapper.Stylers
{
    public class BatchStyler : ScintillaStyler
    {
        public BatchStyler() : base(Lexer.Batch)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            scintilla.Styles[Style.Batch.Default].ForeColor = Color.Black;
            scintilla.Styles[Style.Batch.Default].BackColor = Color.White;

            scintilla.Styles[Style.Batch.Comment].ForeColor = ColorTranslator.FromHtml("#008000");
            scintilla.Styles[Style.Batch.Comment].BackColor = Color.White;

            scintilla.Styles[2].ForeColor = ColorTranslator.FromHtml("#0000FF");
            scintilla.Styles[2].BackColor = Color.White;

            scintilla.Styles[Style.Batch.Label].ForeColor = ColorTranslator.FromHtml("#FF0000");
            scintilla.Styles[Style.Batch.Label].BackColor = ColorTranslator.FromHtml("#FFFF80");

            scintilla.Styles[Style.Batch.Hide].ForeColor = ColorTranslator.FromHtml("#FF00FF");
            scintilla.Styles[Style.Batch.Hide].BackColor = Color.White;

            scintilla.Styles[Style.Batch.Command].ForeColor = ColorTranslator.FromHtml("#0080FF");
            scintilla.Styles[Style.Batch.Command].BackColor = Color.White;

            scintilla.Styles[6].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[6].BackColor = ColorTranslator.FromHtml("#FCFFF0");

            scintilla.Styles[Style.Batch.Operator].ForeColor = Color.Red;
            scintilla.Styles[Style.Batch.Operator].BackColor = Color.White;

        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
            scintilla.SetKeywords(0,
                "assoc aux break call cd chcp chdir choice cls cmdextversion color com com1 com2 com3 com4 con copy country " +
                "ctty date defined del dir do dpath echo else endlocal erase errorlevel exist exit for ftype goto if in loadfix " +
                "loadhigh lpt lpt1 lpt2 lpt3 lpt4 md mkdir move not nul path pause popd prn prompt pushd rd rem ren rename " +
                "rmdir set setlocal shift start time title type ver verify vol");

        }
    }
}
