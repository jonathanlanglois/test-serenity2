using Serenity.ComponentModel;
using System.ComponentModel;

namespace test_serenity2.Games.Columns;

[ColumnsScript("Games.Games")]
[BasedOnRow(typeof(GamesRow), CheckNames = true)]
public class GamesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public int Year { get; set; }
    public string PlatformName { get; set; }
    public string Genre { get; set; }
}