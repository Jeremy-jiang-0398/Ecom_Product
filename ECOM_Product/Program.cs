using ECOM_Product;

class Program
{

    public static void main(String[] args)
    {
        var productOne = new Product(1, "Utensils", 3.45m, 50);

        Console.WriteLine($"Product: {productOne.ProductName}, Stock: {productOne.Stock}");

        productOne.IncreaseStock(10);
        Console.WriteLine($"New stock value is: {productOne.Stock}");

        productOne.DecreaseStock(70);
        Console.WriteLine($"New stock value is: {productOne.Stock}");
    }

}
