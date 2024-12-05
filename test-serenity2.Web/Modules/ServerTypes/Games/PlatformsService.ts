import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PlatformsRow } from "./PlatformsRow";

export namespace PlatformsService {
    export const baseUrl = 'Games/Platforms';

    export declare function Create(request: SaveRequest<PlatformsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PlatformsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PlatformsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PlatformsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PlatformsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PlatformsRow>>;

    export const Methods = {
        Create: "Games/Platforms/Create",
        Update: "Games/Platforms/Update",
        Delete: "Games/Platforms/Delete",
        Retrieve: "Games/Platforms/Retrieve",
        List: "Games/Platforms/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PlatformsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}