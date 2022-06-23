// See https://aka.ms/new-console-template for more information
namespace DemoOperator
{
    class program
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = 10;
            var c = 7;

            var d = a + b * c;

            Console.WriteLine(d);
            //Kurung Kali Bagi Tambah Kurang

            //perbandingan
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            //logika
            Console.WriteLine(a > b && d > a);
            Console.WriteLine(a > b || d == a);


            // float c = (float)20 / 9;
            // Console.WriteLine(c);
        }
    }
}

