using AkoStore.Database;
using AkoStore.Models;

namespace AkoStore.Sevices;

public abstract class BaseService<T> where T : BaseModel
{
    protected AkoStoreDatabase _database;
    public BaseService(AkoStoreDatabase database)
    {
        _database = database;
    }
    public abstract List<T> GetAll();
    public abstract T GetById(Guid id);
    public abstract void Add(T item);
    public abstract void Update(T item);
    public abstract void Delete(Guid id);
}
