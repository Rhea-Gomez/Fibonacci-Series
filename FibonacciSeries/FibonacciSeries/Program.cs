namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 1, a2 = 1, n = 8, a3 = 0;
            Console.Write(a1 + " ");
            Console.Write(a2 + " ");
            for (int i = 2; i < n; i++)
            {
                a3 = a1 + a2;
                Console.Write(a3 + " ");
                a1 = a2;
                a2 = a3;
            }
        }
    }
}