using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<test_serenity2.Games.GamesRow>;
using MyRow = test_serenity2.Games.GamesRow;

namespace test_serenity2.Games;

public interface IGamesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class GamesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGamesListHandler
{
    public GamesListHandler(IRequestContext context)
            : base(context)
    {
    }
}