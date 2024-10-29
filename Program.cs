namespace PracticalWork8OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Задание 1: Фигуры и их площадь\n");

        List<Circle> circles =
        [
            new(5),
            new(10),
            new(2)
        ];

        List<Rectangle> rectangles =
        [
            new(5, 2),
            new(10, 1),
            new(2, 5)
        ];

        for (int i = 1; i < circles.Count + 1; i++)
            Console.WriteLine($"Площадь круга {i}: {MathF.Round(circles[i - 1].GetArea(), 2)}.");

        Console.WriteLine();

        for (int i = 1; i < rectangles.Count + 1; i++)
            Console.WriteLine($"Площадь прямоугольника {i}: {MathF.Round(circles[i - 1].GetArea(), 2)}.");


        Console.WriteLine("\nЗадание 2: Электроприборы и их включение\n");

        List<Appliance> appliances =
        [
            new WashingMachine(),
            new WashingMachine(),
            new WashingMachine(),
            new Refrigerator(),
            new Refrigerator()
        ];

        for (int i = 1; i < appliances.Count + 1; i++)
        {
            Console.Write($"{i}. ");
            appliances[i - 1].TurnOn();
        }


        Console.WriteLine("\nЗадание 3: Транспортные средства и способ их передвижения\n");

        List<Vehicle> vehicles =
        [
            new Car(),
            new Boat(),
            new Car(),
            new Bicycle(),
            new Bicycle()
        ];

        for (int i = 1; i < vehicles.Count + 1; i++)
        {
            Console.Write($"{i}. ");
            vehicles[i - 1].Move();
        }
    }
}

public class Shape
{
    public float Area { get; set; }

    public Shape() => Area = GetArea();

    public virtual float GetArea() => Area;
}

public class Circle : Shape
{
    public float Radius { get; set; }

    public Circle(float radius) => 
        Radius = radius;

    public override float GetArea() =>
        Convert.ToSingle(Math.PI * Radius * Radius);
}

public class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public override float GetArea() =>
        Width * Height;
}

public class Appliance
{
    public virtual void TurnOn() =>
        Console.WriteLine($"Электроприбор включен.");
}

public class WashingMachine : Appliance
{
    public override void TurnOn() => 
        Console.WriteLine($"Стиральная машина включена.");
}

public class Refrigerator : Appliance
{
    public override void TurnOn() =>
        Console.WriteLine($"Холодильник включен.");
}

public class Vehicle
{
    public virtual void Move() => 
        Console.WriteLine("Транспорт движется.");
}

public class Car : Vehicle
{
    public override void Move() => 
        Console.WriteLine("Машина едет по дороге.");
}

public class Bicycle : Vehicle
{
    public override void Move() =>
        Console.WriteLine("Велосипед движется по дорожке.");
}

public class Boat : Vehicle
{
    public override void Move() =>
        Console.WriteLine("Лодка плывёт по воде.");
}