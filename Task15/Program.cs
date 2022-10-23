
Console.Write("Ведите число соответствующее дню недели: ");
string n = Console.ReadLine();
int Day = Convert.ToInt32(n);
Console.Write("Является ли день недели выходным: ");
void Whatday()
{
    if (Day < 6)
    {
        Console.WriteLine("Нет");
    }
    if (Day > 5)
    {
        Console.WriteLine("Да");
    }
}
Whatday();
