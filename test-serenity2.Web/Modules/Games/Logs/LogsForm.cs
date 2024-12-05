using Serenity.ComponentModel;

namespace test_serenity2.Games.Forms;

[FormScript("Games.Logs")]
[BasedOnRow(typeof(LogsRow), CheckNames = true)]
public class LogsForm
{
    public string EntityName { get; set; }
    public int EntityId { get; set; }
    public string Action { get; set; }
}