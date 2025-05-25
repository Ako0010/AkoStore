using AkoStore.Models;

namespace AkoStore.Database;

public class AkoStoreDatabase
{
    public List<Customer> Customers { get; set; }
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; }
    public AkoStoreDatabase()
    {
        Customers = new List<Models.Customer>();
        Products = new List<Models.Product>();
        Orders = new List<Models.Order>();
    }
}
