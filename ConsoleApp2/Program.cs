using System;
using static System.Console;

internal class Program
{
   static void First(Random rnd)
    {

        int ran = rnd.Next(100);
        while (true)
        {

            WriteLine("Введите число:");
            string n1 = ReadLine();
            if (Convert.ToInt32(n1) > ran)
            {
                WriteLine("Надо меньше");
            }
            else if (Convert.ToInt32(n1) < ran)
            {
                WriteLine("Надо больше");
            }
            else if (Convert.ToInt32(n1) == ran)
            {
                WriteLine("Вы угадали");
                break;
            }
        }
    }
    static void Second()
    {
        int[,] arr = new int[11, 11];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                arr[i, j] = (i * j);
                Write(arr[i, j] + "\t");
            }
            WriteLine();
        }
    }
    static void Third()
    {
        string n1;
        WriteLine("Для выхода напишите - выйти");
        while (true)
        {
            n1 = ReadLine();
            if (n1 == "выйти")
            {
                break;
            }
            else
            {
                for (int d = 1; d <= Convert.ToInt32(n1); d++)
                {
                    if (Convert.ToInt32(n1) % d == 0)
                    {
                        Write(d + " ");
                    }

                }
                WriteLine();
            }
        }
    }
    private static void Main()
    {
        string a;
        
        while (true) 
        {
            WriteLine("1.Угадай число. \n2.Таблица умножения \n3.Вывод делителей чисел \n4.Выход ");
            a = ReadLine();
            if (a == "1")
            {
                First(new Random());   
            }
            else if (a == "2")
            {
                Second(); 
            }
            else if (a == "3")
            {
                Third();
            }
            else if (a == "4")
            {
                break;
            }
            else
            {
                WriteLine("Нет такой команды!");
            }
        }
    }
}