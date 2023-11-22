namespace Fibbonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 4000000, first = 0, second = 1, sumEven = 0;

            while (true)
            {
                int next = first + second;

                if (next > limit) break;

                if (next % 2 == 0)
                {
                    sumEven += next;
                }
                first = second;
                second = next;
            }

            Console.WriteLine(sumEven);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}