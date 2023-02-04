// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Yibo!");
// Console.WriteLine("The current time is " + DateTime.Now);

namespace firstApp
{
    class Program 
    {
        static void Main(string[] args)
        {
           //string name = "Yibo";
            //string name2 = "Jameel";
            //int a = 1;
            //int b = 3;
            //Console.WriteLine("This is" + " " + name);
            //Console.WriteLine("And I am" + " " + name2);
            //Console.WriteLine(a + b);

            // Console.WriteLine("Hello. May I have your name?");
            // string userName = Console.ReadLine();
            // Console.WriteLine("Username is: " + userName);
            // Console.WriteLine("Can I have your age?");
            // int userAge = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(userName + " is " + userAge);

            Console.WriteLine("Hello there. Can i ask for your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 18)
            {
                Console.WriteLine("I'm sorry, you are too young!");
            }
            else {
                Console.WriteLine("You can proceed!");
            }

            if (userAge < 18)
            {
                Console.WriteLine("How are you even here anyway? Should you be sleeping right now. It is " + DateTime.Now);
            }
            else if (userAge > 40)
            {
                Console.WriteLine("Don't mean to intrude, but you're really old.");
            }
            else 
            {
                Console.WriteLine("I hope you have a good time ; )");
            }
        }   
    }
}