using AkoStore.Database;
using AkoStore.Models;

namespace AkoStore.Sevices;

public class CustomersService : BaseService<Customer>
{
    public CustomersService(AkoStoreDatabase database) : base(database)
    {
    }

    public override void Add(Customer item)
    {
        _database.Customers.Add(item);
    }

    public override void Delete(Guid id)
    {
        var customer = GetById(id);
        if (customer != null)
        {
            _database.Customers.Remove(customer);
        }
    }

    public override List<Customer> GetAll()
    {
        return _database.Customers;
    }

    public override Customer GetById(Guid id)
    {
        return _database.Customers.FirstOrDefault(c => c.Id == id);
    }

    public override void Update(Customer item)
    {
        var customer = GetById(item.Id);
        if (customer != null)
        {
            customer.Name = item.Name;
            customer.Surname = item.Surname;
            customer.Orders = item.Orders;
        }
    }
}