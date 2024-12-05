using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<test_serenity2.Games.PlatformsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = test_serenity2.Games.PlatformsRow;

namespace test_serenity2.Games;

public interface IPlatformsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PlatformsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPlatformsSaveHandler
{
    public PlatformsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}