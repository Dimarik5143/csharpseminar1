// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double deltaZ = z2 - z1;

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }
        Console.WriteLine("Введите координаты точки A (x1, y1, z1): ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B (x2, y2, z2): ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());
        double z2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance3D(x1, y1, z1, x2, y2, z2);
        Console.WriteLine($"Расстояние между точкой A и точкой B: {distance:F2}");