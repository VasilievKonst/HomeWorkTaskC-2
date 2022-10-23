Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int numb = n.ToString().Length;
int N = Convert.ToInt32(n);
int index = 3;
int step = 1;
if (N < 0)
    {
        numb = numb - 1;
    }
while (index < numb)
{
    step = step * 10;
    index++;
}
void ThirdEL()
{
    if (numb < 3)
    {
        Console.WriteLine("Третье число отсутствует!");
    }
    else
    {
        int resalt = (N / step) % 10;
        Console.WriteLine("Третьим числом является: ");
        Console.WriteLine(resalt);
    }
}
ThirdEL();







/* Вариант №2  в котором число преобразовано в вид массива

int[] array = {1, 23};
int n = array.Length;
Console.WriteLine(n);
void ThirdEL()
{
    if (n <= 2)
    {
        Console.WriteLine("Третий элемент в числе отсутствует! Ошибка!");
    }
    else
    {
        Console.Write("Третьим элементом заданного числа является: ");
        Console.WriteLine(array[2]);
    }
}
ThirdEL();
*/