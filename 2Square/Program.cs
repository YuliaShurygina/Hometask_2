//По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число №1  ");
int numberA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число  №2  ");
int numberB = int.Parse(Console.ReadLine()??"0");

if (numberA /numberB  == numberB)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else if (numberB /numberA  == numberA)
{
    Console.WriteLine("Да, второе число является квадратом первого");
}
else
{
    Console.WriteLine("Нет, ни одно из чисел не является квадратом другого");
}