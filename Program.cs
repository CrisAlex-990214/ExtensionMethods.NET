using ExtensionMethods.NET;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/product", () =>
{
    var products = new ShopRepository().GetProducts();
    //LINQExtensions.OrderByCreatedDate(products);
    return products.OrderByCreatedDate();
});

app.MapGet("/order", () =>
{
    var orders = new ShopRepository().GetOrders();
    //LINQExtensions.OrderBy(orders);
    return orders.OrderBy();
});

app.Run();
