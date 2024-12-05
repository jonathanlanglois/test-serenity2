import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PlatformsForm, PlatformsRow, PlatformsService } from '../../ServerTypes/Games';

@Decorators.registerClass('test_serenity2.Games.PlatformsDialog')
export class PlatformsDialog extends EntityDialog<PlatformsRow, any> {
    protected getFormKey() { return PlatformsForm.formKey; }
    protected getRowDefinition() { return PlatformsRow; }
    protected getService() { return PlatformsService.baseUrl; }

    protected form = new PlatformsForm(this.idPrefix);
}