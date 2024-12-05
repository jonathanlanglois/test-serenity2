import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LogsRow } from "./LogsRow";

export interface LogsColumns {
    Id: Column<LogsRow>;
    EntityName: Column<LogsRow>;
    EntityId: Column<LogsRow>;
    Action: Column<LogsRow>;
}

export class LogsColumns extends ColumnsBase<LogsRow> {
    static readonly columnsKey = 'Games.Logs';
    static readonly Fields = fieldsProxy<LogsColumns>();
}