using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace test_serenity2.Games;

[ConnectionKey("Games"), Module("Games"), TableName("games")]
[DisplayName("Games"), InstanceName("Games")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class GamesRow : Row<GamesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, PrimaryKey, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Column("name"), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Year"), Column("year"), NotNull]
    public int? Year { get => fields.Year[this]; set => fields.Year[this] = value; }

    [DisplayName("Platform Name"), Column("platform_id"), NotNull, ForeignKey(typeof(PlatformsRow)), LeftJoin("j1")]
    [LookupEditor(typeof(PlatformsRow))]
    public int? PlatformId { get => fields.PlatformId[this]; set => fields.PlatformId[this] = value; }

    [DisplayName("Platform Name"), Expression("j1.[name]")]
    public string PlatformName { get => Fields.PlatformName[this]; set => Fields.PlatformName[this] = value; }

    [DisplayName("Genre"), Column("genre"), NotNull]
    public string Genre { get => fields.Genre[this]; set => fields.Genre[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public Int32Field Year;
        public Int32Field PlatformId;
        public StringField PlatformName;
        public StringField Genre;

    }
}