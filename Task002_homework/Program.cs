Console.WriteLine("Введите число a");
string numberA = Console.ReadLine();
Console.WriteLine("Введите число b");
string numberB = Console.ReadLine();
Console.WriteLine("Введите число c");
string numberC = Console.ReadLine();

if ((int.Parse(numberA) > int.Parse(numberB)) & (int.Parse(numberA) > int.Parse(numberC)))
    {
        Console.WriteLine("Max число");
        Console.WriteLine(numberA);
    }
    else if ((int.Parse(numberB) > int.Parse(numberA)) & (int.Parse(numberB) > int.Parse(numberC)))
    {
        Console.WriteLine("Max число");
        Console.WriteLine(numberB);
    }
    else
    {
        Console.WriteLine("Max число");
        Console.WriteLine(numberC);
    }