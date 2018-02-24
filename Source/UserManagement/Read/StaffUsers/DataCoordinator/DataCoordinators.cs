using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Read.StaffUsers.DataCoordinator
{
    public class DataCoordinators : IDataCoordinators
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<DataCoordinator> _collection;
        public DataCoordinators(
            IMongoDatabase database
        )
        {
            _database = database;
            _collection = database.GetCollection<DataCoordinator>("DataConsumer");
        }
        public async Task<DataCoordinator> GetByIdAsync(Guid id)
        {
            return (await _collection.FindAsync(a => a.Id == id)).SingleOrDefault();
        }

        public async Task<IEnumerable<DataCoordinator>> GetAllAsync()
        {
            return (await _collection.FindAsync(_ => true)).ToList();
        }

        public async Task Remove(Guid id)
        {
            await _collection.DeleteOneAsync(a => a.Id == id);
        }

        public async Task Save(DataCoordinator obj)
        {
            await _collection.ReplaceOneAsync(a => a.Id == obj.Id, obj, new UpdateOptions { IsUpsert = true });
        }
    }
}