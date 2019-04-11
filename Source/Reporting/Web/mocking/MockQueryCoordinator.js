import { QueryRequest, Query } from '@dolittle/queries';

export class MockQueryCoordinator {

     /**
     * Execute a query
     * @param {Query} query 
     */
    execute(query) {
        return new Promise((resolve, reject) => {
            resolve({
                //TODO:Call method that returns result based on query instance
            });
        });
    }
}
const mockCommandCoordinator = new MockCommandCoordinator();
export default mockCommandCoordinator;
