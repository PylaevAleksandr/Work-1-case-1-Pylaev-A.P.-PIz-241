using System;

class Program
{
    static void Main()
    {
        int a;
        while (true)
        {
            Console.Write("Введите натуральное число a: ");
            bool isParsedA = int.TryParse(Console.ReadLine(), out a);
            if (isParsedA && a > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число, натуральное число больше 0");
                Console.WriteLine("Введите НАТУРАЛЬНОЕ число (больше 0).");
            }
        }

        int n;
        while (true)
        {
            Console.Write("Введите натуральное число n: ");
            bool isParsedN = int.TryParse(Console.ReadLine(), out n);
            if (isParsedN && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число, натуральное число больше 0");
                Console.WriteLine("Введите НАТУРАЛЬНОЕ число (больше 0).");
            }
        }                                                                                 // Вот теперь мне нравится   

        Console.WriteLine($"Вы ввели a = {a} и n = {n}");


        int result = Power(a, n);
        Console.WriteLine($"{a}^{n} = {result}");
    }
    static int Power(int a, int n)
    {
        if (n == 0) return 1;                             // А в степени 0 = 1
        int result = 1;
        for (int i = 0; i < n; i++)
        {
            result = Multiply(result, a);
        }
        return result;
    }

    static int Multiply(int Q, int W)
    {
        int result = 0;
        for (int i = 0; i < W; i++)
        {
            result += Q;                                  // Используем сложение, чтобы сделать умножение
        }
        return result;
    }
}