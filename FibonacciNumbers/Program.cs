namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(1));
            Console.WriteLine(Fib(2));
            Console.WriteLine(Fib(3));
            Console.WriteLine(Fib(5));
            Console.WriteLine(Fib(50));  //12586269025
        }

        static Dictionary<long, long> dict = new Dictionary<long, long>()
            {
                {0,0 }, {1,1}
            };
        public static long Fib(int n)
        {
            
            if (n==0) { return 0; }

            if(n==1 || n==2) { return 1; }

            if (dict.ContainsKey(n)) { return dict[n]; }

            dict[n] = Fib((n - 1)) + Fib((n - 2));

            return dict[n];
        }
    }
}