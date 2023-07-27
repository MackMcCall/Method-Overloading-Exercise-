namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isDollar)
        {
            int sum = num1 + num2;
            if (isDollar == true)
            {
                if (sum > 1)
                {
                    return $"${sum} dollars";
                }
                return $"${sum} dollar";
            }
            return $"{sum}";
        }
    }
}
