using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите диапазон числа: n =  ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите количество попыток: k = ");
        int k = int.Parse(Console.ReadLine());
        Random random = new Random();
        int a = random.Next(0, n);
        int[] b = new int[k];
        for (int i = 0; i < b.Length; i++)
        {
            if (i == b.Length - 1)
            {
                Console.WriteLine("Начинайте угадывать!");
                int san = int.Parse(Console.ReadLine());
                if (san == a) Console.WriteLine("Угадали! Это " + san);
                else Console.WriteLine("Вы истратили все попытки");
            }
            else
            {
                Console.WriteLine("Угадывайте!");
                int san = int.Parse(Console.ReadLine());
                if (san == a)
                {
                    Console.WriteLine("Угадали! Это " + san);
                    break;
                }
                else
                {
                    if (san < a) Console.WriteLine("Больше");
                    else Console.WriteLine("Меньше");
                }
            }
        }
    }
}