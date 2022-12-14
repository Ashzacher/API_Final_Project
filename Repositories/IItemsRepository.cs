using System;
using System.Collections.Generic;
using Catalog.Entities;
using System.Threading.Tasks;

namespace Catalog.Repositories {
    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreatItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    }
}