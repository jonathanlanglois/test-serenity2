import { StringEditor, IntegerEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface GamesForm {
    Name: StringEditor;
    Year: IntegerEditor;
    PlatformId: LookupEditor;
    Genre: StringEditor;
}

export class GamesForm extends PrefixedContext {
    static readonly formKey = 'Games.Games';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GamesForm.init)  {
            GamesForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = LookupEditor;

            initFormType(GamesForm, [
                'Name', w0,
                'Year', w1,
                'PlatformId', w2,
                'Genre', w0
            ]);
        }
    }
}