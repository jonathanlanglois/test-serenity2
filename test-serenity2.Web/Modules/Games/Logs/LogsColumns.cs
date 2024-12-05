using Serenity.ComponentModel;
using System.ComponentModel;

namespace test_serenity2.Games.Columns;

[ColumnsScript("Games.Logs")]
[BasedOnRow(typeof(LogsRow), CheckNames = true)]
public class LogsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string EntityName { get; set; }
    public int EntityId { get; set; }
    public string Action { get; set; }
}