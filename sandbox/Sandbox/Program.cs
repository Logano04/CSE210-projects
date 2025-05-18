using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"Radius: {myCircle.GetRadius()}");
        Console.WriteLine($"Radius: {myCircle.GetArea()}");

        Cyllinder myCyllinder = new Cyllinder();
        myCyllinder.SetCircle(myCircle);
        myCyllinder.SetHeight(10);
        Console.WriteLine($"Volume: {myCyllinder.GetVolume()}");

    //    Random randomGenerator = new Random();
    //    int randomNumber = new randomGenerator(1,100);
    }
}