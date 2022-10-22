// Вариант №2  в котором число преобразовано в вид массива

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