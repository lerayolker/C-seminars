Console.WriteLine("Введите два числа и мы узнаем яляется ли первое число квадратом второго");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int squareb = b * b;
if (squareb == a)
{
    Console.Write($"Да, первое число {a} - это квадрат второго числа {b}");

}
else
{
    Console.Write($"Нет, певрое число {a} - это не квадрат второго числа {b}");
}