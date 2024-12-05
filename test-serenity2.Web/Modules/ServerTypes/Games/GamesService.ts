import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { GamesRow } from "./GamesRow";

export namespace GamesService {
    export const baseUrl = 'Games/Games';

    export declare function Create(request: SaveRequest<GamesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<GamesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<GamesRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<GamesRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<GamesRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<GamesRow>>;

    export const Methods = {
        Create: "Games/Games/Create",
        Update: "Games/Games/Update",
        Delete: "Games/Games/Delete",
        Retrieve: "Games/Games/Retrieve",
        List: "Games/Games/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>GamesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}