using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<test_serenity2.Games.LogsRow>;
using MyRow = test_serenity2.Games.LogsRow;

namespace test_serenity2.Games;

public interface ILogsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LogsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILogsRetrieveHandler
{
    public LogsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}