using System.Security.Cryptography;

Console.WriteLine("1.Сложить два числа\n2.Вычесть первое из второго\n3.Перемножить два числа\n4.Разделить первое на второе\n5.Возвести в степень N первое число\n6.Найти квадратный корень из числа\n7.Найти 1 процент от числа\n8.Найти факториал из числа\n9.Выйти из программы");

Console.Write("Введите номер операции");
int choose = Convert.ToInt32(Console.ReadLine());

do
{
    if (choose == 1)
    {
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int res = a1 + a2;
        Console.WriteLine($"Результат выражения {a1} + {a2} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 2)
    {
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int res = a1 - a2;
        Console.WriteLine($"Результат выражения {a1} - {a2} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 3)
    {
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int res = a1 * a2;
        Console.WriteLine($"Результат выражения {a1} * {a2} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 4)
    {
        double a1 = Convert.ToDouble(Console.ReadLine());
        double a2 = Convert.ToDouble(Console.ReadLine());
        double res = a1 / a2;
        Console.WriteLine($"Результат выражения {a1} / {a2} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 5)
    {
        double a1 = Convert.ToDouble(Console.ReadLine());
        double a2 = Convert.ToDouble(Console.ReadLine());
        double res = Math.Pow(a1, a2);
        Console.WriteLine($"Результат возведения {a1} в степень {a2} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 6)
    {
        double a1 = Convert.ToDouble(Console.ReadLine());
        double res = Math.Sqrt(a1);
        Console.WriteLine($"Квадратный корень из числа {a1} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 7)
    {
        double a1 = Convert.ToDouble(Console.ReadLine());
        double res = a1 / 100;
        Console.WriteLine($"Один процент от числа {a1} равен {res}");

        Console.Write("Введите номер операции ");
        choose = Convert.ToInt32(Console.ReadLine());
    }

    if (choose == 8)
    {
        int a1 = Convert.ToInt32(Console.ReadLine());
        int n = 1;
        int res = 1;
        while (n != a1 + 1)
        {
            res = res * n;
            n++;
        }
        Console.WriteLine($"Факториал числа {a1} равен {res}");
    }
}
while (choose < 9);