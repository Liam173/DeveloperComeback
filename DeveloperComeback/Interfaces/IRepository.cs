using System;

namespace DeveloperComeback.Interfaces
{
    public interface IRepository<T>
    {
        void Save(T item);
    }
}
