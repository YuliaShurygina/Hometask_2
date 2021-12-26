//Найти расстояние между точками в пространстве 2D
Console.WriteLine("Введите координату X точки A : ");
double xa = double.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите координату Y точки A : ");
double ya = double.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите координату X точки B : ");
double xb = double.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите координату Y точки B : ");
double yb = double.Parse(Console.ReadLine()??"0");

double distance  = Math.Sqrt(((xb - xa)*(xb-xa)) + ((yb - ya)*(yb-ya)));
Console.WriteLine("Расстояние между точками A и B = " + distance);
