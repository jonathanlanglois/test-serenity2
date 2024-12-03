using MyRepository = test_serenity2.Administration.Repositories.UserPermissionRepository;
using MyRow = test_serenity2.Administration.UserPermissionRow;

namespace test_serenity2.Administration.Endpoints;

[Route("Services/Administration/UserPermission/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class UserPermissionEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
    {
        return new MyRepository(Context).Update(uow, request);
    }

    public ListResponse<MyRow> List(IDbConnection connection, UserPermissionListRequest request)
    {
        return new MyRepository(Context).List(connection, request);
    }

    public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request)
    {
        return new MyRepository(Context).ListRolePermissions(connection, request);
    }

    public ListResponse<string> ListPermissionKeys(
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new ListResponse<string>
        {
            Entities = permissionKeyLister.ListPermissionKeys(includeRoles: false).ToList()
        };
    }
}