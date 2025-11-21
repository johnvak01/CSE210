using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // make Products (based on cards from Magic the Gathering)
        Product blackLotus      = new Product("Black Lotus",        1 , 1, 3.01);
        Product oneRing         = new Product("The One Ring",       2 , 2, 2.64);
        Product copyArtifact    = new Product("Copy Artifact",      3,  3, 0.10);
        Product timeTwister     = new Product("Time Twister",       4,  4, 0.08);
        Product lordOfPit       = new Product("Lord of Pit",    5,  5, 0.11);
        Product splendidGenesis = new Product("Splendid Genesis",   6,  6, 0.07);
        // make addresses
        Address whiteHouse = new Address("1600 Pennsylvania Avenue", "Washington DC", "District of Columbia", "USA");
        Address templeSquare = new Address("50 W North Temple Street", "Salt Lake City", "UT", "USA");
        //make customers
        Customer donald = new Customer("Donald T.",whiteHouse);
        Customer russel = new Customer("Russel N.",templeSquare);
        //make orders
        Order christmasOrder = new Order([blackLotus,oneRing,copyArtifact],donald);
        Order birthdayOrder = new Order([timeTwister,lordOfPit, splendidGenesis],russel);

        // create outputs
        Console.WriteLine(christmasOrder.PackingLabel() + "\n" + "Total:\t$" + christmasOrder.calcTotalCost() + "\n" + christmasOrder.ShippingLabel() + "\n");
        Console.WriteLine(birthdayOrder.PackingLabel() + "\n" + "Total:\t$" + birthdayOrder.calcTotalCost() + "\n" + birthdayOrder.ShippingLabel() + "\n");

    }
}