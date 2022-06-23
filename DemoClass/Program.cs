// See https://aka.ms/new-console-template for more information
namespace DemoClass
{
    class program
    {
        static void Main(string[] args)
        {
            Person Fahri = new Person();
            Fahri.firstName = "Fahri";
            Fahri.lastName = "Haidar";

            Fahri.Talk();
        }
    }

    public class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }


        public void Talk()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}

