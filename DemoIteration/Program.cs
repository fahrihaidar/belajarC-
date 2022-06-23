// See https://aka.ms/new-console-template for more information
namespace DemoIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // for
            // for (int i = 0; i < 10; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         //Console.WriteLine(i);
            //     }
            // }

            // for (int i = 10; i >= 10; i--)
            // {
            //     if (i % 2 == 0)
            //     {
            //         //Console.WriteLine(i);
            //     }
            // }

            // var name = "Fahri haidar";

            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            // //foreach statement

            // foreach (var character in name)
            // {
            //     Console.WriteLine(character);
            // }

            // var number = new int[] { 1, 2, 3, 4 };
            // foreach (var item in number)
            // {
            //     Console.WriteLine(item);
            // }

            // while statement
            // int i = 0;
            // while (i < 5) //nilai while akan selalu true
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            int i = 0;
            while (true) //nilai while akan selalu true
            {
                Console.WriteLine("Type your name :");
                var input = Console.ReadLine(); //merupakan perintah untuk membaca input dari user

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                Console.WriteLine("Hello " + input);
            }
        }
    }
}
