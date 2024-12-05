using Serenity.ComponentModel;
using System.ComponentModel;

namespace test_serenity2.Games.Columns;

[ColumnsScript("Games.Platforms")]
[BasedOnRow(typeof(PlatformsRow), CheckNames = true)]
public class PlatformsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public int Year { get; set; }
}