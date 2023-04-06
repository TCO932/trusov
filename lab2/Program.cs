// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"
Выберите операцию:\n
1) Сложение
2) Вычитание
3) Умножение
4) Деление
");
int operation = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите первое число");
double a = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите второе число");
double b = Convert.ToDouble(Console.ReadLine());

string sign = "";
double result = -1;
switch (operation)
{
    case 1: 
        sign = "+";
        result = a + b;
        break;
    case 2: 
        sign = "-";
        result = a - b;
        break;
    case 3: 
        sign = "*";
        result = a * b;
        break;
    case 4: 
        sign = "/";
        result = a / b;
        break;
    default:
        Console.WriteLine("Неправильный выбор операции");
        return;
}

Console.WriteLine($"{a} {sign} {b} = {result}");



