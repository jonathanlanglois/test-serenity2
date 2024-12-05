using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<test_serenity2.Games.GamesRow>;
using MyRow = test_serenity2.Games.GamesRow;

namespace test_serenity2.Games;

public interface IGamesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class GamesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGamesRetrieveHandler
{
    public GamesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}