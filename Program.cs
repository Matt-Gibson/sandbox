namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Something New");

            //Retuning an entered whole number with Parseing
            Console.Write("Enter a Whole Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {number}.");
           
            //Returning an entered decimal with Parseing
            Console.Write("Enter a decimal number: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"You entered {a}.");

            //Concatenating Strings
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"You name is {firstName} {lastName}.");

            //Bool Values
            bool isWorking = true;
            bool isNotWorking = false;

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


        }
    }
}