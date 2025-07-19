using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        OutdoorActivity outdoorActivity = new OutdoorActivity("Rock show in the park", "4 local bands play a free show at Humperdink park", "7-21", "7-10 PM", "187 Smellbert dr", "Somewhere City", "WA", "Sunny - 79°");
        Console.WriteLine($"Standard Details: {outdoorActivity.standardDetails()}");
        Console.WriteLine($"Full Details: {outdoorActivity.outdoorActivityFullDetails()}");
        Console.WriteLine($"Short Description: {outdoorActivity.shortDescription()}");
        Reception reception = new Reception("My Dog's wedding reception", "My dog Humphrey is getting married to his beautiful dog fiance Matilda", "6-18", "6 PM", "11223 Philiophilis rd", "Awawa", "TX", "adamhirt99@gmail.com");
        Console.WriteLine($"Standard Details: {reception.standardDetails()}");
        Console.WriteLine($"Full Details: {reception.receptionFullDetails()}");
        Console.WriteLine($"Short Description: {reception.shortDescription()}");
        Lecture lecture = new Lecture("Getting your hand out of a pringles can", "A lecture from renowned psychologist Dr. Dorvisnki on getting your hand out when it's stuck in a pringles can.", "1-1", "9 AM", "567 Corkscrew Ave", "Terror Town", "PA", "Dr. Dorvinski", 200);
        Console.WriteLine($"Standard Details: {lecture.standardDetails()}");
        Console.WriteLine($"Full Details: {lecture.lectureFullDetails()}");
        Console.WriteLine($"Short Description: {lecture.shortDescription()}");

    }
}