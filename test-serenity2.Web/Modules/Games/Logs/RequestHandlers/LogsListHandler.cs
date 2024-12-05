using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<test_serenity2.Games.LogsRow>;
using MyRow = test_serenity2.Games.LogsRow;

namespace test_serenity2.Games;

public interface ILogsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LogsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILogsListHandler
{
    public LogsListHandler(IRequestContext context)
            : base(context)
    {
    }
}