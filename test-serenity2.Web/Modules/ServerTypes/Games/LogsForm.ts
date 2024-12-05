import { StringEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LogsForm {
    EntityName: StringEditor;
    EntityId: IntegerEditor;
    Action: StringEditor;
}

export class LogsForm extends PrefixedContext {
    static readonly formKey = 'Games.Logs';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LogsForm.init)  {
            LogsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(LogsForm, [
                'EntityName', w0,
                'EntityId', w1,
                'Action', w0
            ]);
        }
    }
}