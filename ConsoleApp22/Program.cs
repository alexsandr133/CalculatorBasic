// See https://aka.ms/new-console-template for more information



Product burger;
burger.price = 50;
burger.name_products = "vopper";
burger.kolichestvo = 2;

int result = burger.returnPrice();
Console.WriteLine(result);


//создаем структуру
struct Product
{
    public int price;
    public string name_products;
    public int kolichestvo;

    public Product(string name_products, int kolichestvo, int price)
    {
        this.name_products = name_products;
        this.price = price;
        this.kolichestvo = kolichestvo;
    }
    public int returnPrice() 
    {
        int result = price * kolichestvo;
        Console.WriteLine("У вас товара на сумму: " + " " + $"{result}"+" " + "название продукта" + " " + $"{name_products}" +" "+ "его количество" + " " + $"{kolichestvo}");
        return result;

    }


}