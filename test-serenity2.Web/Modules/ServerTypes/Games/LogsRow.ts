import { fieldsProxy } from "@serenity-is/corelib";

export interface LogsRow {
    Id?: number;
    EntityName?: string;
    EntityId?: number;
    Action?: string;
}

export abstract class LogsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'EntityName';
    static readonly localTextPrefix = 'Games.Logs';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<LogsRow>();
}