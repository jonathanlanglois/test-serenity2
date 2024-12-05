using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<test_serenity2.Games.PlatformsRow>;
using MyRow = test_serenity2.Games.PlatformsRow;

namespace test_serenity2.Games;

public interface IPlatformsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PlatformsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPlatformsRetrieveHandler
{
    public PlatformsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}