// See https://aka.ms/new-console-template for more information
namespace DemoConditional
{
    class program
    {
        static void Main(string[] args)
        {
            // int hour = 10;

            // if (hour > 0 && hour < 12)
            // {
            //     Console.WriteLine("It's Morning");
            // }
            // else if (hour >= 12 && hour < 18)
            // {
            //     Console.WriteLine("It's Afternoon");
            // }
            // else
            // {
            //     Console.WriteLine("It's Evening");
            // }

            // bool isPremiumCustomer = true;

            // float price = (isPremiumCustomer) ? 20f : 10f;

            // Console.WriteLine(price);

            var currentSeason = Season.Spring;

            switch (currentSeason)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("It's Spring");
                    break;
                default:
                    Console.WriteLine("It's Winter");
                    break;
            }
        }

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
}
