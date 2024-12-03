using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<test_serenity2.Default.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = test_serenity2.Default.MovieRow;

namespace test_serenity2.Default;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}