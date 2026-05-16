namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            byte age = Byte.Parse(Console.ReadLine());

            if(age <= 12)
            {
                Console.WriteLine("You are a child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else if ( age <= 64)
            {
                Console.WriteLine("You are a adult");
            }
            else if (age >= 65)
            {
                Console.WriteLine("You are a pensioner");
            }
           
        }
    }
}
