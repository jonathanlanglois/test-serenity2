import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GamesForm, GamesRow, GamesService } from '../../ServerTypes/Games';

@Decorators.registerClass('test_serenity2.Games.GamesDialog')
export class GamesDialog extends EntityDialog<GamesRow, any> {
    protected getFormKey() { return GamesForm.formKey; }
    protected getRowDefinition() { return GamesRow; }
    protected getService() { return GamesService.baseUrl; }

    protected form = new GamesForm(this.idPrefix);
}