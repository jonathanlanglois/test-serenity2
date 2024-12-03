using MyRow = test_serenity2.Administration.LanguageRow;
using MyRequest = Serenity.Services.SaveRequest<test_serenity2.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace test_serenity2.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}