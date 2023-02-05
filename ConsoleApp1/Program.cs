using System;

namespace ConsoleApp1
{

    class Program
    {

        static void Main()
        {

            int num_1 = 0;
            int num_2 = 0;
            string Hai;
            int All = 0;
            try
            {
                Console.WriteLine("Перше число щоб пітдвердити нажміть Enter");
                num_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("впишіть один з цих символів(+, -, *, /) щоб пітдвердити нажміть Enter");
                Hai = Console.ReadLine();
                Console.WriteLine("Друге число щоб пітдвердити нажміть Enter");
                num_2 = Convert.ToInt32(Console.ReadLine());

            if (Hai == "+")
                All = num_1 + num_2;
            else if (Hai == "-")
                All = num_1 - num_2;
            else if (Hai == "*")
                All = num_1 * num_2;
            
            
                if (Hai == "/")
                    All = num_1 / num_2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("не можна дiлити на нуль");
            }
            catch (FormatException)
            {
                Console.WriteLine("щось пiшло не так");
            }

            Console.WriteLine("= " + All);
            Console.WriteLine("нажміть Enter щоб вийти");
            Console.ReadKey();

        }

    }

}