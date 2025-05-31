using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to earn 1,000,000 usd in 5 minutes", "Tang Gerald", 300);
        video1.AddComment("twinx", "Wow! After watching this I now shower in $100 bills😎");
        video1.AddComment("parrotx2", "You da goat ma men. You da goat");
        video1.AddComment("annoymous", "Ummm guys...is there any step I missed... my $1000 disappeared from my account.");


        Video video2 = new Video("How to get rich fast in 2025", "Jay", 120);
        video2.AddComment("Rubie", "I didn't get rich fast. Waste of time");
        video2.AddComment("Merlin", "Feel sorry for all the kids who bought this"); 
        video2.AddComment("Max", "Mom am rich! LOL"); 
        video2.AddComment("Cookie", "I blame myself for not getting rich in the first place");

        Video video3 = new Video("How to be a successful young lad", "MrMoney", 800);
        video3.AddComment("Rawpanzel", "Am out of the streets with this");
        video3.AddComment("villian", "Vengence will be mine. I am batman");
        video3.AddComment("Cuotie", "Best video ever");       
       
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            int numComments = video.GetNumberOfComments();
            Console.WriteLine($"Number of comments: {numComments}");
        }
    }
}