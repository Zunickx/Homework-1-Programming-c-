Console.WriteLine("Введите число");
string numberA = Console.ReadLine();
//int numberA = 10;

if(int.Parse(numberA) % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}