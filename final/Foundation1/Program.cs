using System;

class Program
{
    static void Main(string[] args)
    {
        // Create video list
        List<Video> videos = new List<Video> {};

        // Create first video
        Video video1 = new Video("Top 10 Slugs", "SlugPilled24", 632);
        video1.AddComment("CommentFred", "This video is truly insightful");
        video1.AddComment("JoeCommenter", "I do enjoy me some slugs");
        video1.AddComment("SlugStealer", "I have come to steal all 10 of the slugs");
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("PvZ Gameplay Video 26", "CrazyDave", 1923);
        video2.AddComment("Dr_Zomboss", "Take this down at once!");
        video2.AddComment("Gregory027", "Cool video but why on planet earth are your sunflowers at the front?");
        video2.AddComment("Lobotomite", "Do you ever in the oven hot in food cold hot out hot eat the food");
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Pirated Spongebob Season 2 Episode 5", "PatchyThePirate", 728);
        video3.AddComment("ScurvyMatey94", "Yarharharharharrr!");
        video3.AddComment("DavyJones", "Thar be treasure!");
        video3.AddComment("PlunderPlank", "Ahoy me hearties!");
        videos.Add(video3);

        // Iterate through the list of videos and display all
        foreach (Video video in videos)
        {
            video.DisplayAll();
        }
            
    }
}