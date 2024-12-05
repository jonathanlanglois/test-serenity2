import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { LogsRow } from "./LogsRow";

export namespace LogsService {
    export const baseUrl = 'Games/Logs';

    export declare function Create(request: SaveRequest<LogsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LogsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LogsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LogsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LogsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LogsRow>>;

    export const Methods = {
        Create: "Games/Logs/Create",
        Update: "Games/Logs/Update",
        Delete: "Games/Logs/Delete",
        Retrieve: "Games/Logs/Retrieve",
        List: "Games/Logs/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>LogsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}