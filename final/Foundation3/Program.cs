using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Someplace St", "New York", "NY", "USA");
        Address address2 = new Address("123 Somewhere Ave", "Los Angeles", "CA", "USA");
        Address address3 = new Address("123 Nowhere Blvd", "Miami", "FL", "USA");

        Lecture lecture = new Lecture("Tech Stuff", "A cool meeting for cool tech, probably.", new DateTime(2025, 5, 12, 10, 0, 0), address1, "Dr. John Techguy", 100);
        Reception reception = new Reception("Shooting Plants", "An evening to gun down plants.", new DateTime(2025, 6, 1, 18, 30, 0), address2, "gunplants@events.com");
        OutdoorGathering outdoor = new OutdoorGathering("Dwarf Convention", "A day of dwarven music and root beer.", new DateTime(2025, 7, 20, 15, 0, 0), address3, "Sunny");

        Console.WriteLine("==================== LECTURE ====================");
        Console.WriteLine($"Standard Details: {lecture.GetStandardDetails()}\n");
        Console.WriteLine($"\nFull Details: {lecture.GetFullDetails()}\n");
        Console.WriteLine($"\nShort Description: {lecture.GetShortDescription()}\n");

        Console.WriteLine("\n==================== RECEPTION ====================");
        Console.WriteLine($"Standard Details: {reception.GetStandardDetails()}\n");
        Console.WriteLine($"\nFull Details: {reception.GetFullDetails()}\n");
        Console.WriteLine($"\nShort Description: {reception.GetShortDescription()}\n");

        Console.WriteLine("\n==================== OUTDOOR GATHERING ====================");
        Console.WriteLine($"Standard Details: {reception.GetStandardDetails()}\n");
        Console.WriteLine($"\nFull Details: {reception.GetFullDetails()}\n");
        Console.WriteLine($"\nShort Description: {reception.GetShortDescription()}\n");

        Console.ReadLine();
    }
}