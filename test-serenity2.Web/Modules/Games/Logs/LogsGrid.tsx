import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LogsColumns, LogsRow, LogsService } from '../../ServerTypes/Games';
import { LogsDialog } from './LogsDialog';

@Decorators.registerClass('test_serenity2.Games.LogsGrid')
export class LogsGrid extends EntityGrid<LogsRow> {
    protected getColumnsKey() { return LogsColumns.columnsKey; }
    protected getDialogType() { return LogsDialog; }
    protected getRowDefinition() { return LogsRow; }
    protected getService() { return LogsService.baseUrl; }
}