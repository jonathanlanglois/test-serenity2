using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace test_serenity2.Games.Pages;

[PageAuthorize(typeof(PlatformsRow))]
public class PlatformsPage : Controller
{
    [Route("Games/Platforms")]
    public ActionResult Index()
    {
        return this.GridPage<PlatformsRow>("@/Games/Platforms/PlatformsPage");
    }
}