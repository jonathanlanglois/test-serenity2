using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;
using test_serenity2.Administration;

namespace test_serenity2.Games;

[ConnectionKey("Games"), Module("Games"), TableName("platforms")]
[DisplayName("Platforms"), InstanceName("Platforms")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript(Permission = PermissionKeys.Security)]
public sealed class PlatformsRow : Row<PlatformsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), PrimaryKey, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Column("name"), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Year"), Column("year"), NotNull]
    public int? Year { get => fields.Year[this]; set => fields.Year[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public Int32Field Year;

    }
}