// See https://aka.ms/new-console-template for more information
namespace DemoKonversi

{
    class program
    {

        static void Main(string[] args)
        {
            byte a = 1;
            int b = a;
            Console.WriteLine(b);

            // int c = 2;
            // byte d = (byte)c;
            // Console.WriteLine(d);

            int c = 1000;
            byte d = (byte)c; // bisa run, tetapi hasil jadi 232 karena maks byte ada 232
            Console.WriteLine(d);


            string e = "20";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string benar = "true";
            bool isTrue = Convert.ToBoolean(benar);
            Console.WriteLine(isTrue);

        }
    }
}
