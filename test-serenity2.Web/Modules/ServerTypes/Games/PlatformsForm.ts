import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PlatformsForm {
    Name: StringEditor;
    Year: IntegerEditor;
}

export class PlatformsForm extends PrefixedContext {
    static readonly formKey = 'Games.Platforms';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PlatformsForm.init)  {
            PlatformsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(PlatformsForm, [
                'Name', w0,
                'Year', w1
            ]);
        }
    }
}