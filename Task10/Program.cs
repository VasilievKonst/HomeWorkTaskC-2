// Два вида решения:.
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


/*
2 способ

Console.Write("Введите трехзначное число: ");
string str = Console.ReadLine();
int numb = Convert.ToInt32(str);
void secondnumb() => Console.WriteLine((numb/10)%10);
secondnumb();
*/
