namespace Assignment_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.2.1
            Console.WriteLine("Enter two integers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} and {b} {(a == b ? "are" : "are not")} equal");

            // 1.2.2
            Console.WriteLine("Enter a natural number: ");
            int sum = 0, nNatNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The first {nNatNum} natural number is : ");
            for (int i = 1; i <= nNatNum; i++)
            {
                Console.Write(i + " ");
                sum = sum + i;
            }
            Console.WriteLine("\nThe Sum is : " + sum);

            // 1.2.3
            string option = "";
            do
            {
                Console.WriteLine($"Enter 'a' 's' 'm' 'd' to perform a math operation on {a} and {b} or 'q' to quit: ");

                option = (Console.ReadLine()).ToLower();

                switch (option)
                {
                    case "q":
                        break;
                    case "a":
                        Console.WriteLine($"Addition of {a} and {b}: {a + b}");
                        break;
                    case "s":
                        Console.WriteLine($"Substraction of {a} and {b}: {a - b}");
                        break;
                    case "m":
                        Console.WriteLine($"Multiplication of {a} and {b}: {a * b}");
                        break;
                    case "d":
                        if(b == 0)
                        {
                            Console.WriteLine("Error: divide by zero!");
                        }
                        else
                        {
                            Console.WriteLine($"Division of {a} and {b}: {a / b}");
                        }
                        break;
                    default:
                        Console.WriteLine("Not a valid option!");
                        break;
                }
            }
            while (option != "q");
        }
    }
}