using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace test_serenity2.Default.Pages;

[PageAuthorize(typeof(MovieRow))]
public class MoviePage : Controller
{
    [Route("Default/Movie")]
    public ActionResult Index()
    {
        return this.GridPage<MovieRow>("@/Default/Movie/MoviePage");
    }
}