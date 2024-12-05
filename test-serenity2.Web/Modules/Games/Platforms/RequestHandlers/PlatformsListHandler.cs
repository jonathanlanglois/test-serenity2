using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<test_serenity2.Games.PlatformsRow>;
using MyRow = test_serenity2.Games.PlatformsRow;

namespace test_serenity2.Games;

public interface IPlatformsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PlatformsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPlatformsListHandler
{
    public PlatformsListHandler(IRequestContext context)
            : base(context)
    {
    }
}