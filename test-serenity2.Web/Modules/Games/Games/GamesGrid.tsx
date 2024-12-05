import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GamesColumns, GamesRow, GamesService } from '../../ServerTypes/Games';
import { GamesDialog } from './GamesDialog';

@Decorators.registerClass('test_serenity2.Games.GamesGrid')
export class GamesGrid extends EntityGrid<GamesRow> {
    protected getColumnsKey() { return GamesColumns.columnsKey; }
    protected getDialogType() { return GamesDialog; }
    protected getRowDefinition() { return GamesRow; }
    protected getService() { return GamesService.baseUrl; }
}