using AkoStore.Database;
using AkoStore.Models;

namespace AkoStore.Sevices;

public class ProductService:BaseService<Product>
{
    public ProductService(AkoStoreDatabase database) : base(database)
    {
    }
    public override List<Product> GetAll()
    {
        return _database.Products;
    }
    public override Product GetById(Guid id)
    {
        return _database.Products.FirstOrDefault(p => p.Id == id);

    }
    public override void Add(Product item)
    {
        _database.Products.Add(item);
    }
    public override void Update(Product item)
    {
        var product = GetById(item.Id);
        if (product != null)
        {
            product.Name = item.Name;
            product.Price = item.Price;
            product.Description = item.Description;
        }
    }
    public override void Delete(Guid id)
    {
        var product = GetById(id);
        if (product != null)
        {
            _database.Products.Remove(product);
        }
    }
}
