using System;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("Murderer Spider", "Sidney", "Australia", "Animal's Kingdom");
            Address address2 = new Address("Oz's Castle", "Emerald City", "Farland", "Yellow Brick Road");

            Lecture lecture = new Lecture("Tech Talk", "Learn about new technologies", DateTime.Now, new TimeSpan(14, 0, 0), address1, "Your Mom", 50);
            Reception reception = new Reception("Networking Event", "Networking and socializing", DateTime.Now.AddDays(1), new TimeSpan(18, 0, 0), address2, "mrpepeelpollo@joemama.com");
            OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "Enjoy food and games outdoors", DateTime.Now.AddDays(2), new TimeSpan(12, 0, 0), address1, "Thunderstorm");

            Console.WriteLine("Standard Details:");
            Console.WriteLine("-----------------");
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(outdoorGathering.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine("--------------");
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(outdoorGathering.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Descriptions:");
            Console.WriteLine("---------------------");
            Console.WriteLine(lecture.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(outdoorGathering.GetShortDescription());
        }
    }
}
