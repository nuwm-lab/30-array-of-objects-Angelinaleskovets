using System; //1
class Sphere
{
    public double Radius { get; }
    public double CenterX { get; }
    public double CenterY { get; }
    public double CenterZ { get; }

    public Sphere(double radius, double x, double y, double z)
    {
        Radius = radius;
        CenterX = x;
        CenterY = y;
        CenterZ = z;
    }

    //git hjgjgh
    // Метод для перевірки, чи точка потрапляє в кулю.
    public bool IsPointInside(double x, double y, double z)
    {
        double dx = x - CenterX;
        double dy = y - CenterY;
        double dz = z - CenterZ;
        double distanceSquared = dx * dx + dy * dy + dz * dz;
        return distanceSquared <= Radius * Radius;
    }
}

class Program
{
    static void Main()  //check
    {
        // Створення об'єкта кулі.
        Sphere sphere = new Sphere(5.0, 0.0, 0.0, 0.0); // Радіус 5, центр (0, 0, 0)

        // Введення координат точки
        Console.WriteLine("Введіть координати точки (x, y, z):");
        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("z = ");
        double z = Convert.ToDouble(Console.ReadLine());

        // Перевірка, чи точка всередині кулі
        bool inside = sphere.IsPointInside(x, y, z);

        if (inside)
        {
            Console.WriteLine("Точка знаходиться всередині кулі або на її поверхні.");
        }
        else
        {
            Console.WriteLine("Точка знаходиться поза кулею.");
        }
    }
}

