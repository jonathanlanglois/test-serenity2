import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface PlatformsRow {
    Id?: number;
    Name?: string;
    Year?: number;
}

export abstract class PlatformsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Games.Platforms';
    static readonly lookupKey = 'Games.Platforms';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PlatformsRow>('Games.Platforms') }
    static async getLookupAsync() { return getLookupAsync<PlatformsRow>('Games.Platforms') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PlatformsRow>();
}