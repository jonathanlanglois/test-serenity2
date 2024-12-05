import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PlatformsRow } from "./PlatformsRow";

export interface PlatformsColumns {
    Id: Column<PlatformsRow>;
    Name: Column<PlatformsRow>;
    Year: Column<PlatformsRow>;
}

export class PlatformsColumns extends ColumnsBase<PlatformsRow> {
    static readonly columnsKey = 'Games.Platforms';
    static readonly Fields = fieldsProxy<PlatformsColumns>();
}