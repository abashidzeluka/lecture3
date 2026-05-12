namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator +,-,*,/ ");
            char i = char.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num_2 = int.Parse(Console.ReadLine());

            switch(i)
            {
                case '+':
                    Console.WriteLine("Your number is: " + (num_1 + num_2));
                    break;
                case '-':
                    Console.WriteLine("Your number is: " + (num_1 - num_2));
                    break;
                case '*':
                    Console.WriteLine("Your number is: " + (num_1 * num_2));
                    break;
                case '/':
                    Console.WriteLine("Your number is: " + (num_1 / num_2));
                    break;
                default: Console.WriteLine("Invalid operator!");
                    break;
            }
        }
    }
}
