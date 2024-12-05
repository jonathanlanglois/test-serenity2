using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace test_serenity2.Games;

[ConnectionKey("Games"), Module("Games"), TableName("logs")]
[DisplayName("Logs"), InstanceName("Logs")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class LogsRow : Row<LogsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), PrimaryKey, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Entity Name"), Column("entity_name"), QuickSearch, NameProperty]
    public string EntityName { get => fields.EntityName[this]; set => fields.EntityName[this] = value; }

    [DisplayName("Entity Id"), Column("entity_id")]
    public int? EntityId { get => fields.EntityId[this]; set => fields.EntityId[this] = value; }

    [DisplayName("Action"), Column("action")]
    public string Action { get => fields.Action[this]; set => fields.Action[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField EntityName;
        public Int32Field EntityId;
        public StringField Action;

    }
}