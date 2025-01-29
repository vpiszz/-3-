using System;
class Shape
{
    private string color;
    private double x, y;

    public Shape(string col, double xCoord, double yCoord)
    {
        color = col;
        x = xCoord;
        y = yCoord;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Цвет: {color}, Координаты центра: ({x}, {y})");
    }
}


class Circle : Shape
{
    private double radius;

    public Circle(string col, double xCoord, double yCoord, double r) : base(col, xCoord, yCoord)
    {
        radius = r;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Радиус: {radius}");
    }
}


class Rectangle : Shape
{
    private double width, height;

    public Rectangle(string col, double xCoord, double yCoord, double w, double h) : base(col, xCoord, yCoord)
    {
        width = w;
        height = h;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Ширина: {width}, Высота: {height}");
    }
}


class Triangle : Shape
{
    private double baseLength, height;

    public Triangle(string col, double xCoord, double yCoord, double b, double h) : base(col, xCoord, yCoord)
    {
        baseLength = b;
        height = h;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Основание: {baseLength}, Высота: {height}");
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle("Фиолетовый", 0, 0, 5);
        Rectangle r = new Rectangle("Розовый", 2, 3, 4, 6);
        Triangle t = new Triangle("Синий", -1, -1, 3, 5);

        Console.WriteLine("Информация о фигурах:");
        c.Display();
        Console.WriteLine();
        r.Display();
        Console.WriteLine();
        t.Display();
    }
}
