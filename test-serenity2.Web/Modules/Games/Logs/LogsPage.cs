using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace test_serenity2.Games.Pages;

[PageAuthorize(typeof(LogsRow))]
public class LogsPage : Controller
{
    [Route("Games/Logs")]
    public ActionResult Index()
    {
        return this.GridPage<LogsRow>("@/Games/Logs/LogsPage");
    }
}