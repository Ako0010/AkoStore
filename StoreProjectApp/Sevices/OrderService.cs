using AkoStore.Database;
using AkoStore.Models;

namespace AkoStore.Sevices;

public class OrderService : BaseService<Order>
{
    public OrderService(AkoStoreDatabase database) : base(database)
    {
    }

    public override void Add(Order item)
    {
        foreach (var product in item.Products)
        {
            item.TotalPrice += product.Price;
        }
        _database.Orders.Add(item);
    }

    public override void Delete(Guid id)
    {
        var product = GetById(id);
        if (product != null)
        {
            _database.Orders.Remove(product);
        }
    }

    public override List<Order> GetAll()
    {
        return _database.Orders.ToList();
    }

    public override Order GetById(Guid id)
    {
        return _database.Orders.FirstOrDefault(p => p.Id == id);
    }

    public override void Update(Order item)
    {
        var order = GetById(item.Id);
        if (order != null)
        {
            order.Products = item.Products;
            order.TotalPrice = 0; 
            foreach (var product in item.Products)
            {
                order.TotalPrice += product.Price;
            }
        }
    }
}
