using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = test_serenity2.Games.LogsRow;

namespace test_serenity2.Games;

public interface ILogsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LogsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILogsDeleteHandler
{
    public LogsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}