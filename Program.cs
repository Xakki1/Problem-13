int a, b;
string s;
Console.WriteLine("Введите номер карты = ");
a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 6:
        Console.WriteLine("Шестерка");   break;
    case 7:
        Console.WriteLine("Семерка ");   break;
    case 8:
        Console.WriteLine("Восьмерка "); break;
    case 9:
        Console.WriteLine("Девятка ");   break;
    case 10:
        Console.WriteLine("Десятка");    break;
    case 11:
        Console.WriteLine("Валет ");     break;
    case 12:
        Console.WriteLine("Дама ");      break;
    case 13:
        Console.WriteLine("Король ");    break;
    case 14:
        Console.WriteLine("Туз");        break;
}
Console.WriteLine("Введите номер масти = ");
b = Convert.ToInt32(Console.ReadLine());
switch (b)
{
    case 1:
        Console.WriteLine(a + "Пики");  break;
    case 2:
        Console.WriteLine(" Трефы "); break;
    case 3: 
        Console.WriteLine(" Бубны "); break;
    case 4:
        Console.WriteLine(" Червы "); break;
}
Console.WriteLine();
Console.ReadKey();