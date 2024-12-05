using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace test_serenity2.Games.Pages;

[PageAuthorize(typeof(GamesRow))]
public class GamesPage : Controller
{
    [Route("Games/Games")]
    public ActionResult Index()
    {
        return this.GridPage<GamesRow>("@/Games/Games/GamesPage");
    }
}