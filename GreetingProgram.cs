namespace ConsoleApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Total number of your enrolled courses: ");
            int courses;
            courses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total of enrolled courses" + courses);
            Console.WriteLine("Price of my favorite book: " + price);

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}