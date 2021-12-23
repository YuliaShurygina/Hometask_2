// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите порядковый номер дня недели от 1(понедельник) до 7(воскресенье): ");
int number = int.Parse(Console.ReadLine()??"0");
if (number <= 5)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("является выходным днем");
}


