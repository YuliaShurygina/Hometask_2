// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool X = true;
bool Y = false;



//Console.Write("Введите значение Х: ");
//string x = Console.ReadLine();
//bool X = Boolean.Parse(x);

//Console.Write("Введите значение Y: ");
//string y = Console.ReadLine();
//bool Y = Boolean.Parse(y);

if ((!(X | Y)) == (!X & !Y))
    Console.WriteLine("Высказывание истинно");
else
    Console.WriteLine("Высказывание ложно");



