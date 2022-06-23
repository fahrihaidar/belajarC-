// See https://aka.ms/new-console-template for more information
namespace DemoArray
{
    class program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            var number2 = new int[4]; // {1, 3, 5, 7};

            number[0] = 1;
            number[1] = 3;
            number[2] = 5;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            Console.WriteLine(number2[0]);//0
            Console.WriteLine(number2[1]);//0
            Console.WriteLine(number2[2]);//0
        }
    }
}
