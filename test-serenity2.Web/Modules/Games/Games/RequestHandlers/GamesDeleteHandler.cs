using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = test_serenity2.Games.GamesRow;

namespace test_serenity2.Games;

public interface IGamesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class GamesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGamesDeleteHandler
{
    public GamesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void OnAfterDelete()
    {
        base.OnAfterDelete();

        if (Row != null)
        {
            var logsSaveRequest = new SaveRequest<LogsRow>
            {
                Entity = new LogsRow
                {
                    EntityName = "Games",
                    EntityId = Row.Id,
                    Action = "Deleted"
                }
            };
            var logsSaveHandler = new LogsSaveHandler(Context);
            logsSaveHandler.Process(UnitOfWork, logsSaveRequest);
        }
    }
}