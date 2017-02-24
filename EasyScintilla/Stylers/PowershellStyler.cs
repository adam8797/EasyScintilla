using System.Drawing;
using ScintillaNET;

namespace ScintillaWrapper.Stylers
{
    public class PowerShellStyler : ScintillaStyler
    {
        public PowerShellStyler() : base(Lexer.PowerShell)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            scintilla.Styles[Style.PowerShell.Default].ForeColor = Color.Black;
            scintilla.Styles[Style.PowerShell.Default].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Comment].ForeColor = ColorTranslator.FromHtml("#008000");
            scintilla.Styles[Style.PowerShell.Comment].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.String].ForeColor = ColorTranslator.FromHtml("#808080");
            scintilla.Styles[Style.PowerShell.String].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Character].ForeColor = ColorTranslator.FromHtml("#808080");
            scintilla.Styles[Style.PowerShell.Character].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Number].ForeColor = ColorTranslator.FromHtml("#FF8000");
            scintilla.Styles[Style.PowerShell.Number].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Variable].ForeColor = Color.Black;
            scintilla.Styles[Style.PowerShell.Variable].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Operator].ForeColor = ColorTranslator.FromHtml("#000080");
            scintilla.Styles[Style.PowerShell.Operator].BackColor = Color.White;

            scintilla.Styles[8].ForeColor = Color.Blue;
            scintilla.Styles[8].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Cmdlet].ForeColor = ColorTranslator.FromHtml("#8000FF");
            scintilla.Styles[Style.PowerShell.Cmdlet].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.Alias].ForeColor = ColorTranslator.FromHtml("#0080FF");
            scintilla.Styles[Style.PowerShell.Alias].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.CommentStream].ForeColor = ColorTranslator.FromHtml("#008080");
            scintilla.Styles[Style.PowerShell.CommentStream].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.HereString].ForeColor = ColorTranslator.FromHtml("#808080");
            scintilla.Styles[Style.PowerShell.HereString].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.HereCharcter].ForeColor = ColorTranslator.FromHtml("#808080");
            scintilla.Styles[Style.PowerShell.HereCharcter].BackColor = Color.White;

            scintilla.Styles[Style.PowerShell.CommentDocKeyword].ForeColor = ColorTranslator.FromHtml("#008080");
            scintilla.Styles[Style.PowerShell.CommentDocKeyword].BackColor = Color.White;
        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
            scintilla.SetKeywords(1,
                "break continue do else elseif filter for foreach function if in return switch until where while");
            scintilla.SetKeywords(2,
                "add-content add-history add-member add-pssnapin clear-content clear-item clear-itemproperty " +
                "clear-variable compare-object convertfrom-securestring convert-path convertto-html convertto-securestring " +
                "copy-item copy-itemproperty export-alias export-clixml export-console export-csv foreach-object " +
                "format-custom format-list format-table format-wide get-acl get-alias get-authenticodesignature " +
                "get-childitem get-command get-content get-credential get-culture get-date get-eventlog get-executionpolicy " +
                "get-help get-history get-host get-item get-itemproperty get-location get-member get-pfxcertificate " +
                "get-process get-psdrive get-psprovider get-pssnapin get-service get-tracesource get-uiculture get-unique " +
                "get-variable get-wmiobject group-object import-alias import-clixml import-csv invoke-expression " +
                "invoke-history invoke-item join-path measure-command measure-object move-item move-itemproperty " +
                "new-alias new-item new-itemproperty new-object new-psdrive new-service new-timespan new-variable " +
                "out-default out-file out-host out-null out-printer out-string pop-location push-location read-host " +
                "remove-item remove-itemproperty remove-psdrive remove-pssnapin remove-variable rename-item rename-itemproperty " +
                "resolve-path restart-service resume-service select-object select-string set-acl set-alias set-authenticodesignature " +
                "set-content set-date set-executionpolicy set-item set-itemproperty set-location set-psdebug set-service set-tracesource " +
                "set-variable sort-object split-path start-service start-sleep start-transcript stop-process stop-service stop-transcript " +
                "suspend-service tee-object test-path trace-command update-formatdata update-typedata where-object write-debug write-error " +
                "write-host write-output write-progress write-verbose write-warning");
            scintilla.SetKeywords(3,
                "ac asnp clc cli clp clv cpi cpp cvpa diff epal epcsv fc fl foreach ft fw gal gc gci gcm gdr ghy gi gl gm gp gps " +
                "group gsv gsnp gu gv gwmi iex ihy ii ipal ipcsv mi mp nal ndr ni nv oh rdr ri rni rnp rp rsnp rv rvpa sal sasv " +
                "sc select si sl sleep sort sp spps spsv sv tee where write cat cd clear cp h history kill lp ls mount mv popd ps " +
                "pushd pwd r rm rmdir echo cls chdir copy del dir erase move rd ren set type");
            scintilla.SetKeywords(4,
                "component description example externalhelp forwardhelpcategory forwardhelptargetname functionality inputs link " +
                "notes outputs parameter remotehelprunspace role synopsis");
        }
    }
}
