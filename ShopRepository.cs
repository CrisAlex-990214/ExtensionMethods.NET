namespace ExtensionMethods.NET
{
    public class ShopRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            yield return new Product("T-shirt", 45, DateTime.Now.AddDays(2));
            yield return new Product("Shoe", 57, DateTime.Now.AddDays(-2));
            yield return new Product("Jacket", 12, DateTime.Now.AddDays(5));
        }

        public IEnumerable<Order> GetOrders()
        {
            yield return new Order("Order 1", 23, DateTime.Now.AddDays(-3));
            yield return new Order("Order 2", 56, DateTime.Now.AddDays(1));
            yield return new Order("Order 3", 47, DateTime.Now.AddDays(3));
        }
    }

    public record Product(string Name, decimal Price, DateTime CreatedDate);
    public record Order(string Description, decimal Total, DateTime CreatedDate);
}
