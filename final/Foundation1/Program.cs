using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // create a video list
        List<Video> videos = new();

        // create each video and add it to a list
        Video video1 = new("Mantis vs. Spider", "AwesomeNatureInsects", 452);
        Video video2 = new("Rain Ambience Music | 1 HOUR MIX", "Sounds&Beats", 3601);
        Video video3 = new("dog meme from social media", "RandomVids", 11);
        Video video4 = new("Why do we procrastinate?", "WorldSpeeches", 1316);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // creating and adding comments to the videos
        video1.AddComment("user1302","Awesome video! never seen anything like it!");
        video1.AddComment("James_12234","I saw one of those in my backyard, they are really bigger than I expected!");
        video1.AddComment("Emily Notfake","I can't stand these videos, so gross!!");
        
        video2.AddComment("Matt Daemon","This is so relaxing!");
        video2.AddComment("Sleepy BOy","I literally fell asleep with this zzzz");
        video2.AddComment("user1302","Great for studying");
        video2.AddComment("piano.-.","If you're feeling down, remember: life has its ups and downs, and no matter how bad you feel, it's always going to get better in the end. Have a nice day");

        video3.AddComment("Funnyguy32","this got me crying T.T");
        video3.AddComment("100percentRealNotFake","Oh man I was looking for this, thank you");
        video3.AddComment("Doge","completely disrespectful... -.-");

        video4.AddComment("LucasBP","This is so interesting!");
        video4.AddComment("Don Smile","I never thought about it this way");
        video4.AddComment("AverageUser89","Great work @WorldSpeeches, this one is very good");

        // display videos
        Console.WriteLine("--List of Videos--");

        foreach (Video v in videos)
        {
            v.DisplayVideo();
            v.DisplayComments();
        }

    }
}