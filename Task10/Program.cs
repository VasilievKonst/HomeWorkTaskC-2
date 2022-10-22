// Два вида решения в разных ветках.
// 1 способ

Console.Write("Введите трехзначное число: ");
string str = Console.ReadLine();
void printres()
{
Char[] numb = str.ToCharArray();
Console.Write("Второй символ трехзначного числа равен: ");
Console.WriteLine(numb[1]);
}
printres();