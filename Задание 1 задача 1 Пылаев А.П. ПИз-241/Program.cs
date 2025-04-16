using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число a: ");   //Ввод чисел через выведенную строку
        int a = Convert.ToInt32(Console.ReadLine());
                                                          //Добавить проверку чисел на натуральность с возвратом к вводу что б не вылетала консоль при вводе неправильного числа
        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

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