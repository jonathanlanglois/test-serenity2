using Serenity.ComponentModel;

namespace test_serenity2.Games.Forms;

[FormScript("Games.Games")]
[BasedOnRow(typeof(GamesRow), CheckNames = true)]
public class GamesForm
{
    public string Name { get; set; }
    public int Year { get; set; }
    public int PlatformId { get; set; }
    public string Genre { get; set; }
}