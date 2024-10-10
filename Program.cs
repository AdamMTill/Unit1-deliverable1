Console.WriteLine("Greetings! I am your virtual restocking assistant.");

{
    int tsvi = 100;
    int rvi = 40;
    Console.WriteLine("There are " + tsvi + " sodas in stock. How many sodas have sold today?");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string si = Console.ReadLine();
    var a = int.Parse(si);
    {
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        int svi = a;
        if ((tsvi - svi)
            <= rvi)
        {
            if (svi > tsvi)
            {
                Console.WriteLine("Inconcievable! You couldn't have possibly sold more sodas than were in stock. Did you mistype?");
            }
            Console.WriteLine("Uh Oh! Looks like the soda needs to be restocked.");
        }
        Console.WriteLine("There are " + (tsvi - svi) + " sodas left.");
    }
}
{
    int tsvii = 40;
    int rvii = 20;
    Console.WriteLine("There are " + tsvii + " chips in stock. How many chips have sold today?");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string sii = Console.ReadLine();
    var b = int.Parse(sii);
    {
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        int svii = b;
        if ((tsvii - svii)
            <= rvii)
        {
            if (svii > tsvii)
            {
                Console.WriteLine("Inconcievable! You couldn't have possibly sold more chips than were in stock. Did you mistype?");
            }
            Console.WriteLine("Uh Oh! Looks like the chips need to be restocked.");
        }
        Console.WriteLine("There are " + (tsvii - svii) + " chips left.");
    }
}
{
    int tsviii = 60;
    int rviii = 40;
    Console.WriteLine("There are " + tsviii + " candy in stock. How much candy has sold today?");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    string siii = Console.ReadLine();
    var c = int.Parse(siii);
    {
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        int sviii = c;
        if ((tsviii - sviii)
            <= rviii)
        {
            if (sviii > tsviii)
            {
                Console.WriteLine("Inconcievable! You couldn't have possibly sold more candy than was in stock. Did you mistype?");
            }
            Console.WriteLine("Uh Oh! Looks like the candy needs to be restocked.");
        }
        Console.WriteLine("There are " + (tsviii - sviii) + " candies left.");
    }
}