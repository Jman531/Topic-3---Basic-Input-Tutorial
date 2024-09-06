namespace Topic_3___Basic_Input_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            int number;
            double numberDecimal;

            Console.WriteLine("Say hello!");
            response = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"You said: {response}");

            Console.WriteLine();

            Console.WriteLine("Give me an integer: ");
            if(Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();

                Console.WriteLine("You gave me a " + number);
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("You didn't give me a integer so the number will be set to " + number + "!");
            }

            Console.WriteLine();

            Console.WriteLine("Give me a number: ");
            if (Double.TryParse(Console.ReadLine(), out numberDecimal))
            {
                Console.WriteLine();

                Console.WriteLine("You gave me the number " + numberDecimal + "!");
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("You didn't give me a number so the number will be set to " + numberDecimal + "!");
            }

            Console.ReadLine();
        }
    }
}
