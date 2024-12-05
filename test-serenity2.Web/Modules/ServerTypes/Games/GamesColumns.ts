import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { GamesRow } from "./GamesRow";

export interface GamesColumns {
    Id: Column<GamesRow>;
    Name: Column<GamesRow>;
    Year: Column<GamesRow>;
    PlatformName: Column<GamesRow>;
    Genre: Column<GamesRow>;
}

export class GamesColumns extends ColumnsBase<GamesRow> {
    static readonly columnsKey = 'Games.Games';
    static readonly Fields = fieldsProxy<GamesColumns>();
}