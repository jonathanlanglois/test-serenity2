import { fieldsProxy } from "@serenity-is/corelib";

export interface GamesRow {
    Id?: number;
    Name?: string;
    Year?: number;
    PlatformId?: number;
    PlatformName?: string;
    Genre?: string;
}

export abstract class GamesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Games.Games';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<GamesRow>();
}