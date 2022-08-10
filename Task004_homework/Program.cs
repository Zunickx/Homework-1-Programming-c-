Console.WriteLine("Введите число:");
string evenNumbers = Console.ReadLine();

int i = 1;
while(i <= int.Parse(evenNumbers))
{
    if(i % 2 == 0) {
        Console.WriteLine(i);
    }
    i++;
}