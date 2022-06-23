// See https://aka.ms/new-console-template for more information
namespace DemoArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            var numbers2 = new int[5] { 4, 2, 1, 3, 5 };

            Console.WriteLine("Length :" + numbers2.Length);

            var index = Array.IndexOf(numbers2, 4);
            Console.WriteLine("Index of 4 :" + index);

            // Array.Clear(numbers2, 0, 2);

            // foreach (var item in numbers2)
            // {
            //     Console.WriteLine(item);
            // }

            // Array.Copy(numbers2, numbers, 2);

            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }

            Array.Sort(numbers2);
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(numbers2);
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }
        }
    }
}

