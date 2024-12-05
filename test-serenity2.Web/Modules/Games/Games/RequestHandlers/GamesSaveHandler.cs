using MyRequest = Serenity.Services.SaveRequest<test_serenity2.Games.GamesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = test_serenity2.Games.GamesRow;

namespace test_serenity2.Games;

public interface IGamesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class GamesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGamesSaveHandler
{
    public GamesSaveHandler(IRequestContext context)
            : base(context)
    {
    }

    protected override void AfterSave()
    {
        base.AfterSave();

        if (Row != null)
        {
            var logsSaveRequest = new SaveRequest<LogsRow>
            {
                Entity = new LogsRow
                {
                    EntityName = "Games",
                    EntityId = Row.Id,
                    Action = IsCreate ? "Created" : "Updated"
                }
            };
            var logsSaveHandler = new LogsSaveHandler(Context);
            logsSaveHandler.Process(UnitOfWork, logsSaveRequest);
        }
    }
}