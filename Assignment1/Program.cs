namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userName = "admin";
            string userPass = "1234";

            Console.Write("Enter username: ");
            string userNameInp = Console.ReadLine();
            Console.Write("Enter password: ");
            string userPassInp = Console.ReadLine();

            if (userName != userNameInp)
            {
                Console.WriteLine("Access Denied!");
            }
            else if (userPass == userPassInp)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
    }
}
