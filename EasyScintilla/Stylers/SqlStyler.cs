using System.Drawing;
using ScintillaNET;

namespace EasyScintilla.Stylers
{
    public class SqlStyler : ScintillaStyler
    {
        public SqlStyler()
            : base(Lexer.Sql, lineNumbers: true, codeFolding: true, braceMatching: true, autoIndent: true)
        {
        }

        public override void ApplyStyle(ScintillaNET.Scintilla scintilla)
        {
            // Set the Styles
            scintilla.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128); //Dark Gray
            scintilla.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228); //Light Gray
            scintilla.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            scintilla.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            scintilla.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            scintilla.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            scintilla.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            scintilla.Styles[Style.Sql.Word2].ForeColor = Color.Fuchsia;
            scintilla.Styles[Style.Sql.User1].ForeColor = Color.Gray;
            scintilla.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192); //Medium Blue-Green
            scintilla.Styles[Style.Sql.String].ForeColor = Color.Red;
            scintilla.Styles[Style.Sql.Character].ForeColor = Color.Red;
            scintilla.Styles[Style.Sql.Operator].ForeColor = Color.Black;
        }

        public override void RemoveStyle(ScintillaNET.Scintilla scintilla)
        {
        }

        public override void SetKeywords(ScintillaNET.Scintilla scintilla)
        {
            // Set keyword lists
            // Word = 0
            scintilla.SetKeywords(0, "go add alter as authorization backup begin bigint binary bit break " +
                                     "browse bulk by cascade case catch check checkpoint close clustered " +
                                     "column commit compute constraint containstable continue create current " +
                                     "cursor cursor database date datetime datetime2 datetimeoffset dbcc " +
                                     "deallocate decimal declare default delete deny desc disk distinct " +
                                     "distributed double drop dump else end errlvl escape except exec execute " +
                                     "exit external fetch file fillfactor float for foreign freetext freetexttable " +
                                     "from full function goto grant group having hierarchyid holdlock identity " +
                                     "identity_insert identitycol if image index insert int intersect into key kill " +
                                     "lineno load merge money national nchar nocheck nocount nolock nonclustered " +
                                     "ntext numeric nvarchar of off offsets on open opendatasource openquery " +
                                     "openrowset openxml option order over percent plan precision primary print " +
                                     "proc procedure public raiserror read readtext real reconfigure references " +
                                     "replication restore restrict return revert revoke rollback rowcount " +
                                     "rowguidcol rule save schema securityaudit select set setuser shutdown " +
                                     "smalldatetime smallint smallmoney sql_variant statistics table " +
                                     "tablesample text textsize then time timestamp tinyint to top tran " +
                                     "transaction trigger truncate try union unique uniqueidentifier update " +
                                     "updatetext use user values varbinary varchar varying view waitfor when " +
                                     "where while with writetext xml ");
            // Word2 = 1
            scintilla.SetKeywords(1, "ascii cast char charindex ceiling coalesce collate contains convert " +
                                     "current_date current_time current_timestamp current_user floor isnull " +
                                     "max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            scintilla.SetKeywords(4, "all and any between cross exists in inner is join left like not null " +
                                     "or outer pivot right some unpivot ( ) * ");
            // User2 = 5
            scintilla.SetKeywords(5, "sys objects sysobjects ");
        }
    }
}