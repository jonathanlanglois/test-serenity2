import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { LogsForm, LogsRow, LogsService } from '../../ServerTypes/Games';

@Decorators.registerClass('test_serenity2.Games.LogsDialog')
export class LogsDialog extends EntityDialog<LogsRow, any> {
    protected getFormKey() { return LogsForm.formKey; }
    protected getRowDefinition() { return LogsRow; }
    protected getService() { return LogsService.baseUrl; }

    protected form = new LogsForm(this.idPrefix);
}