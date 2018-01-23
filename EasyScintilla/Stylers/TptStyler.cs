namespace EasyScintilla.Stylers
{
    public class TptStyler : SqlStyler
    {
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
                                     "where while with writetext xml " +
                                     //Custom TPT
                                     "define job operator type schema attributes varchar integer decimal character apply step to select from");
            // Word2 = 1
            scintilla.SetKeywords(1, "ascii cast char charindex ceiling coalesce collate contains convert " +
                                     "current_date current_time current_timestamp current_user floor isnull " +
                                     "max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            scintilla.SetKeywords(4, "all and any between cross exists in inner is join left like not null " +
                                     "or outer pivot right some unpivot ( ) * " +
                                     //Custom TPT
                                     "update load odbc");
            // User2 = 5
            scintilla.SetKeywords(5, "sys objects sysobjects ");
        }
    }
}