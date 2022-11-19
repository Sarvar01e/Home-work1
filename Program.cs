namespace Home_work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");

            string a;

             a = Console.ReadLine();

            Console.WriteLine("Enter number 2");

            string b;

            b = Console.ReadLine();

            int c = Convert.ToInt32(a);
            int d =  Convert.ToInt32(b);

            int result = (c + d) / 2;

            Console.WriteLine("arithmetic mean is\t" + result);

            
        }
    }
}