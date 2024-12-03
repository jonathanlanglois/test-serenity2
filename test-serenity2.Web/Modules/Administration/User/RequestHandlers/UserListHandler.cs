using MyRow = test_serenity2.Administration.UserRow;
using MyRequest = test_serenity2.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<test_serenity2.Administration.UserRow>;

namespace test_serenity2.Administration;

public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}