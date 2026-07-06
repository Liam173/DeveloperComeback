using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        public void Save(T item)
        {
            // Implementation for saving the item
            Console.WriteLine($"Saving item of type {typeof(T).Name}");
        }
    }
}
