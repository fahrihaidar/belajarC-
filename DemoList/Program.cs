// See https://aka.ms/new-console-template for more information
namespace DemoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            var numbers2 = new List<int> { 1, 2, 3, 4, 5 };

            numbers2.Add(10);
            numbers2.Add(20);

            numbers2.AddRange(new int[3] { 11, 12, 13 });

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Index of 10 :" + numbers2.IndexOf(10));

            Console.WriteLine("Last index of 10 :" + numbers2.LastIndexOf(10));

            Console.WriteLine("Count :" + numbers2.Count);

            numbers2.Remove(10);
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            // Operasi tidak diizinkan
            // foreach (var item in numbers2)
            // {
            //     if (item == 10)
            //     {
            //         numbers2.Remove(item);
            //         break;
            //     }
            // }

            for (int i = 0; i < numbers2.Count; i++)
            {
                if (numbers2[i] == 10)
                {
                    numbers2.Remove(numbers2[i]);
                    break;
                }
                foreach (var item in numbers2)
                {
                    Console.WriteLine(item);
                }
            }

            numbers2.Clear();
            Console.WriteLine("DIHAPUS");

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("HABIS");
        }
    }
}
