namespace AkoStore.Models;

public class Order:BaseModel
{
    public double TotalPrice { get; set; }
    public List<Product> Products { get; set; }
}
