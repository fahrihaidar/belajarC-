// See https://aka.ms/new-console-template for more information
namespace DemoString
{
    class program
    {
        static void Main(string[] args)
        {
            string firstName = "Fahri";
            var lastName = "Haidar";

            var fullName = firstName + " " + lastName;

            var fullName2 = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);

            var names = new string[3] { "Dikara", "Kafi", "Haidar" };
            var namesCombination = string.Join("-", names);

            Console.WriteLine(namesCombination);
        }
    }
}

