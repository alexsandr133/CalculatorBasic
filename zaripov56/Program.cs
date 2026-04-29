// See https://aka.ms/new-console-template for more information

StatusOrder zakaz1;
zakaz1.name = "бмв е34";
struct StatusOrder
{   
    string name;
    int id;
    decimal price;
    int quantity;
    int OrderStatus;
    
    public StatusOrder(string name,int id, decimal price,  int OrderStatus)
    {   
        this.name = name;
        this.id = id;
        this.price = price;
        this.OrderStatus = OrderStatus;
    }
    public double ReturnStatus()
    {
        switch(OrderStatus)
        {
            case (1):
            Console.WriteLine("заказ оформлен");
            break;
            default:
            case (2):
            Console.WriteLine("заказ отменен");
            break;
        }
        Console.WriteLine("информация о заказе: "+" "+$"{id}"+" "+"его цена"+" "+$"{price}"+" "+"его cтатус"+" "+$"{OrderStatus}");
        return OrderStatus;
        
    }
}
enum Status
{
  zakaz_placed= 1,
   zakaz_cancel = 2
   
}
