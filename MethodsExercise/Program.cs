using System.Diagnostics.CodeAnalysis;
using System.Windows.Markup;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sum = add(1, 2, 3);
            Console.WriteLine($"Sum equals {sum}");

            var product = multiply(3, 4, 2, 8);
            Console.WriteLine($"Product equals {product}");
        }
        public static int add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static int multiply(params int[] numbers)
        {
            int product = 0;
            foreach (int num in numbers)
            {
                product += num;
            }
            return product;
        }
    }

}
