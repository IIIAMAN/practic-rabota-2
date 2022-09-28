using System.Security.Claims;

namespace KONECHPRAKT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(" \n\n 1. Игра угадай число\n 2. Таблица умножения\n 3. Вывод делителей числа\n 4. Выход\n ");
                string A = Console.ReadLine();
                if (A == "4")
                {
                    vihod();
                    break;
                }
                if (A == "1")
                {
                 zadacha1();
                }
                if (A == "2")
                {
                 zadacha2();
                }
                if (A == "3")
                {
                 zadacha3();
                }
            } while ("A" != "4");
            Console.WriteLine("\n Вы вышли из программы ");            
        }
        static void zadacha1()
        {          
                Console.WriteLine(" Угадайте число от 1 до 100! ");
                Random baka = new Random();
                int zadumannoe = baka.Next(1, 100);
                string number;
                do
                {
                    Console.Write(" Ваш вариант: ");
                    number = Console.ReadLine();

                    if (int.Parse(number) < zadumannoe)
                        Console.WriteLine(" \nНадо больше ");
                    if (int.Parse(number) > zadumannoe)
                        Console.WriteLine(" \nНадо меньше ");
                }
                while (int.Parse(number) != zadumannoe);
                Console.WriteLine(" \n Вы угадали!!!! ");
                Console.WriteLine(" Выберите следующую программу или выберите выход. ");           
        }
        static void zadacha2()
        {
            Console.WriteLine(" Таблица умножения ");
            int[,] matriza = new int[10, 1];
            for (int m = 1; m < 10; m++)
            {
                for (int l = 1; l < 10; l++)
                {
                    Console.Write("\t" + m * l);
                }
                Console.WriteLine(" \t ");
            }
            Console.WriteLine("\n Выберите следующую программу или выберите выход. ");
        }
        static void zadacha3()
        {
            Console.WriteLine("\n Введи число: ");
            int g = int.Parse(Console.ReadLine());
            for (int b = 1; b <= g; b++)
            {
                if (g % b == 0)
                {
                    Console.Write("\t" + b );
                }
            }
            Console.WriteLine(" \n Выберите следующую программу или выберите выход. ");
        }
        static void vihod()
        {
            Console.WriteLine(" Выход "); 
        }
    }
}
