using Serenity.ComponentModel;

namespace test_serenity2.Games.Forms;

[FormScript("Games.Platforms")]
[BasedOnRow(typeof(PlatformsRow), CheckNames = true)]
public class PlatformsForm
{
    public string Name { get; set; }
    public int Year { get; set; }
}