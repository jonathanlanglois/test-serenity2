using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = test_serenity2.Games.PlatformsRow;

namespace test_serenity2.Games;

public interface IPlatformsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PlatformsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPlatformsDeleteHandler
{
    public PlatformsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}