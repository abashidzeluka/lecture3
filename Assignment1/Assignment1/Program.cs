namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName, userPass;
            userName = "admin";
            userPass = "1234";

            string userNameInp, userPassInp;

            Console.Write("Enter username: ");
            userNameInp = Console.ReadLine();
            Console.Write("Enter password: ");
            userPassInp = Console.ReadLine();

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
