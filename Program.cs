namespace SandBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Something New");

            //Retuning an entered whole number with TryParse for protecting against improper input
            Console.Write("Enter a Whole Number: ");
            if (!int.TryParse(Console.ReadLine(), out var number))
            {
                Console.WriteLine("Input Type Not Accepted");
                Environment.Exit(0);
            }
            Console.WriteLine($"You entered: {number}");

            //Using already Parsed and checked int value to set properties of Structure class object
            Console.WriteLine("Creating New Class Object of Structure...");
            Structure barn = new Structure();
            barn.SetLength(number);
            barn.SetWidth(number);
            barn.SetHeight(number);
            Console.WriteLine($"Barn height is {barn.GetHeight()}");
            Console.WriteLine($"Barn width is {barn.GetWidth()}");
            Console.WriteLine($"Barn length is {barn.GetLength()}");
            

            //Returning an entered decimal with TryParse for protecting against improper input
            Console.Write("Enter a decimal number: ");
            if (!decimal.TryParse(Console.ReadLine(), out var a))
            {
                Console.WriteLine("Input Type Not Accepted");
                Environment.Exit(0);
            }
            Console.WriteLine($"You entered {a}");

            //Switch Statement to evaluate multiple cases
            switch (a)
            {
                case <10:
                    Console.WriteLine("Under 10");
                    break;
                case >10:
                    Console.WriteLine("Over 10");
                    break;
                default:
                    Console.WriteLine("Right on 10");
                    break;
            }


            //Concatenating Strings
            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine($"You name is {firstName} {lastName}.");

            //Bool Values
            var isWorking = true;
            var isNotWorking = false;

            if (isWorking)
            {
                Console.WriteLine($"isWorking is set to {isWorking}.");
            }
            if (isNotWorking)
            {
                Console.WriteLine($"isNotWorking is not set to {isNotWorking}.");
            }
            else
            {
                Console.WriteLine($"isNotWorking is set to {isNotWorking}.");
            }

            //Character examples with Write vs WriteLine
            char abc = 'H';
            char def = 'a';

            Console.Write(abc);
            Console.WriteLine(def);

            Console.WriteLine(abc);
            Console.WriteLine(def);

            //Using a Custom Class
            Printer.Print(firstName);
            Printer.DoubleTap(firstName);

            //For Loop with printing increment variable
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("LOOPing {0}", i);
            }
            
            //Array
            string[] names = new string[2];
            names[0] = "tom";
            names[1] = "tina";
            Console.WriteLine($"This is {names[0]} and {names[1]}");



        }
    }
}