using System;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            int userName = int.Parse(Console.ReadLine());
            if (userName >= 0)
                userName += 5;
            else
                userName -= 5;
            //Task 1.2
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
                Console.WriteLine(number1);
            else if (number2 > number1 && number2 > number3)
                Console.WriteLine(number2);
            else
                Console.WriteLine(number3);
            //Task 1.3
            int result = 0;
            for (int i = 0; i <= 3; i++)
            {
                int userNrumber = int.Parse(Console.ReadLine());
                if (userNrumber > 0)
                    result += userNrumber;
            }
            Console.WriteLine(result);
            //Task 1.4
            int x = int.Parse(Console.ReadLine());
            if (x > 10)
                x *= 2;
            Console.WriteLine(x);
            //Task 1.5
            int userNomer = int.Parse(Console.ReadLine());
            switch (userNomer)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Нет такого");
                    break;
            }


            //Task 2.1
            int f = 200;
            while (true)
            {
                if (f % 17 == 0)
                    break;
                else
                    f++;
            }
            Console.WriteLine(f);
            //Task 2.2
            double rast = 10;
            double metrsw = 0.05;
            for (int day = 1; day < 100; day++)
            {
                rast = Math.Round(rast * metrsw, 1);
                if (Math.Floor(rast) == 20)
                    Console.WriteLine($"{Math.Floor(rast)}: {day}");
                if (Math.Floor(rast) >= 100)
                {
                    Console.WriteLine($"{Math.Floor(rast)}: {day}");
                    break;
                }

            }
            //Task 2.3
            int numberFact = int.Parse(Console.ReadLine());
            int resultation = 1;
            for (int e = 1; e <= numberFact; e++)
            {
                resultation *= e;
            }
            Console.WriteLine(resultation);

            //Task 2.4
            int numberT = int.Parse(Console.ReadLine());
            for (int y = 2; y < numberT; y++)
            {
                if (numberT % y == 0)
                {
                    Console.WriteLine(y);
                    break;
                }
            }

        }
    }
}
