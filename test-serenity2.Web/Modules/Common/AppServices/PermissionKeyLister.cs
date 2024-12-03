using test_serenity2.Administration;

namespace test_serenity2.AppServices;

public class PermissionKeyLister(ITwoLevelCache cache, ITypeSource typeSource)
    : BasePermissionKeyLister(cache, typeSource)
{
    protected override string GetCacheGroupKey()
    {
        return RoleRow.Fields.GenerationKey;
    }
}