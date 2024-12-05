using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<test_serenity2.Games.LogsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = test_serenity2.Games.LogsRow;

namespace test_serenity2.Games;

public interface ILogsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LogsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILogsSaveHandler
{
    public LogsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}