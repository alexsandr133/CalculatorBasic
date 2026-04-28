// See https://aka.ms/new-console-template for more information
Rectangle rectangle = new Rectangle(7, 8);
rectangle.returnInformation();
public class Rectangle
{
    public int width;
    public int height;
    public int area;

    public int Width
    {
        get => width;
        private set
        {
            if (value < 5) width = 5;
            else if (value > 100) width = 100;
            else width = width;
        }
    }
        public Rectangle(int width, int height)
        {
        area = width * height;
        this.area = area;
        this.width = width;
        this.height = height;
        }
        public void returnInformation()
        {
        Console.WriteLine("площадь вашего прямоугольника: "+" "+$"{area}"+" "+"длина вашего прямоуголтника"+" "+$"{width}");
        }
    }
