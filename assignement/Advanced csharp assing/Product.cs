namespace Advanced_csharp_assing;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
}

public class Supplier
{
    public int ID { get; set; }
    public string Name { get; set; }
}

public class Company
{
    private Dictionary<Product, int> inventory = new Dictionary<Product, int>();

    public void AddProduct(Product product, int quantity)
    {
        if (inventory.ContainsKey(product))
        {
            inventory[product] += quantity;
        }
        else
        {
            inventory[product] = quantity;
        }
    }

    public void Sell(Product product, int quantity)
    {
        if (inventory.ContainsKey(product))
        {
            if (inventory[product] >= quantity)
            {
                inventory[product] -= quantity;
                if (inventory[product] < 5)
                {
                    Console.WriteLine($"Low stock alert: {product.Name} is below 5.");
                }
            }
            else
            {
                Console.WriteLine("Not enough stock to complete the sale.");
            }
        }
        else
        {
            Console.WriteLine("Product not found in inventory.");
        }
    }
}
