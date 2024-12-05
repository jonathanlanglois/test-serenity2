import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PlatformsColumns, PlatformsRow, PlatformsService } from '../../ServerTypes/Games';
import { PlatformsDialog } from './PlatformsDialog';

@Decorators.registerClass('test_serenity2.Games.PlatformsGrid')
export class PlatformsGrid extends EntityGrid<PlatformsRow> {
    protected getColumnsKey() { return PlatformsColumns.columnsKey; }
    protected getDialogType() { return PlatformsDialog; }
    protected getRowDefinition() { return PlatformsRow; }
    protected getService() { return PlatformsService.baseUrl; }
}