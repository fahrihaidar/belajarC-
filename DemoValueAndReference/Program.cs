// See https://aka.ms/new-console-template for more information
namespace DemoValueAndReference
{
    class program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;

            b++;

            Console.WriteLine(string.Format("a : {0}, b: {1}", a, b));

            //passing parrameter by reference, 
            //arr1 mengikuti nilai arr2 dimana nilai index 0 pada nilai pertama juga akan berubah, karena arr1&arr2 merujuk pada nilai yang sama
            var arr1 = new int[3] { 1, 3, 5 };
            var arr2 = arr1;

            arr2[0] = 0;

            Console.WriteLine(string.Format("arr1[0] : {0}, arr2: {1}", arr1[0], arr2[0]));


            //passing value dan reference
            // var number = 5;
            // Increment(5);
            // Console.WriteLine(number);

            // var person = new Person() { Age = 29 };
            // makeOld(person);
            // Console.WriteLine(person.Age);

        }
    }

    public static void Increment(int number)
    {
        number += 10;

    }

    public static void makeOld(Person person)
    {
        person.Age += 10;
    }
}

public class Person
{
    public int Age;
}
