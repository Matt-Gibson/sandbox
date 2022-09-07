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


        }
    }
}