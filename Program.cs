internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("Greetings! I am your virtual restocking assistant.");
            int sodastotal = 100;
            Console.WriteLine("There are " + sodastotal + " sodas in stock. How many sodas have sold today?");
            string inputsodas = Console.ReadLine();
            int sodassold = int.Parse(inputsodas);
            {
                if (!(sodassold < sodastotal))
                    Console.WriteLine("Invalid input: Too high!");
            }

            sodastotal = sodastotal - sodassold;
            Console.WriteLine("There are " + sodastotal + " sodas left in stock.");

            int chipstotal = 40;
            Console.WriteLine("There are " + chipstotal + " chips in stock. How many chips have sold today?");
            string inputchips = Console.ReadLine();
            int chipssold = int.Parse(inputchips);
            {
                if (!(chipssold < chipstotal))
                    Console.WriteLine("Invalid input: Too high!");
            }

            chipstotal = chipstotal - chipssold;
            Console.WriteLine("There are " + chipstotal + " chips left in stock.");

            int candiestotal = 60;
            Console.WriteLine("There are " + candiestotal + " candies in stock. How many candies have sold today?");
            string inputcandies = Console.ReadLine();
            int candiessold = int.Parse(inputcandies);
            {
                if (!(candiessold < candiestotal))
                    Console.WriteLine("Invalid input: Too high!");
            }

            candiestotal = candiestotal - candiessold;
            Console.WriteLine("There are " + candiestotal + " candies left in stock.");

            int sodarestock = 40;
            int chiprestock = 20;
            int candyrestock = 40;

            Console.WriteLine("Here are the items you must restock:");
            if (sodarestock >= sodastotal)
            {
                Console.WriteLine("Soda needs to be restocked!");
            }
            if (chiprestock >= chipstotal)
            {
                Console.WriteLine("Chips need to be restocked!");
            }
            if (candyrestock >= candiestotal)
            {
                Console.WriteLine("Candy need to be restocked!");
            }
        }
    }
}