using System;

class Program
{
    static void Main(string[] args)
    {
        // create new addresses
        Address address1 = new("495 Grove Street", "New York", "New York", "USA");
        Address address2 = new("650 Hipolito Yrigoyen", "Lomas de Zamora", "Buenos Aires", "Argentina");
        Address address3 = new("Bernabe Marquez Av. 504", "San Isidro", "Buenos Aires", "Argentina");

        LectureEvent lecture = new("Why you shouldn't trust boredom", "Are you actually bored, or is something else going on? Educator Kevin H. Gary shares three practical takeaways to deal with the doldrums, so you can take control of your attention, figure out which feelings to trust and name the real problem.", "June 6, 2023", "17:00 PM", address1, "Kevin H. Gary", 500);
        ReceptionEvent reception = new("Tech Week 2023","Techweek curates exciting programming that allows a global spotlight to shine on each ecosystem and its leaders.", "December 6, 2023", "9:00 AM - 17:00 PM", address2, "Reception@email.com");
        OutdoorEvent outdoor = new("4x4 Trucks Exhibition", "Adrenaline and pure emotion with the Off-Road Fun fantastic performances!", "From February 13 to 15, 2023", "9:00 AM - 18:00 PM", address3, "22°C, Mostly Cloudy");

        Console.WriteLine(lecture.RenderFull());
        Console.WriteLine(lecture.RenderStandard());
        Console.WriteLine(lecture.RenderShort());

        Console.WriteLine("--------------------------------------------------------------------------");

        Console.WriteLine(reception.RenderFull());
        Console.WriteLine(reception.RenderStandard());
        Console.WriteLine(reception.RenderShort());

        Console.WriteLine("--------------------------------------------------------------------------");

        Console.WriteLine(outdoor.RenderFull());
        Console.WriteLine(outdoor.RenderStandard());
        Console.WriteLine(outdoor.RenderShort());
    }
}