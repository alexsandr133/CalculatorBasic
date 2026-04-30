// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;
using System.Security;
using System.Security.Cryptography.X509Certificates;





InventoryManager Tovar="bmw";
Tovar.name_tovar = "bmw m5";
Tovar.id = 1;
Tovar.numberTovar = 1;
Tovar.StatusOrder = true;

//класс PublicInventory
struct InventoryManager
{
    int number_tovar;
    int id;
    string name_tovar;
    int kolichestvo;
    bool StatusOrder;
    public InventoryManager(int number_tovar,int id, string name_tovar, int kolichestvo, bool StatusOrder)
    {   
        this.number_tovar = number_tovar;
        this.id = id;
        this.name_tovar = name_tovar;
        this.kolichestvo = kolichestvo;
        this.StatusOrder = StatusOrder;
    }
    public int addTovars()
    {
        int places_shop = 100000;
        
        if (kolichestvo > places_shop)
        {
            Console.WriteLine("ВЫ добавили  товар  на склад");
             Console.WriteLine("товар и информация о нем: "+" "+$"{name_tovar}"+" "+"его id"+" "+$"{id}"+" "+$"{number_tovar}");
             

        }
        else
        {
             Console.WriteLine("мест нет");
        }
    }
    public int removeTovar()
    {   
        var number_tovar = 0 ;
        int places_shop = 100000;
        int total =  places_shop - number_tovar; 
        return total;
        Console.WriteLine("склад и информация о нем: "+" "+$"{name_tovar}"+" "+" "+$"{number_tovar}"+" "+$"{places_shop}");
    }
    public void ReturnInformation()
    {
         
         Console.WriteLine("товар и информация о нем: "+" "+$"{name_tovar}"+" "+"его id"+" "+$"{id}"+" "+$"{number_tovar}");
    }


}

