using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Exploring the Depths of Space", "AstroGalaxy", 250);
        video1.AddComment(new Comment("StarWatcher", "Incredible views of the cosmos!"));
        video1.AddComment(new Comment("GalacticDude", "Can you make more on black holes?"));
        video1.AddComment(new Comment("NebulaNancy", "The music in this is so atmospheric."));
        video1.AddComment(new Comment("CosmosKid", "I love the detailed explanation about stars."));
        video1.AddComment(new Comment("SpaceSurfer", "This makes me want to buy a telescope."));
        video1.AddComment(new Comment("AlienBeliever", "Do you think there's life out there?"));

        Video video2 = new Video("The Secrets of the Ocean", "DeepSeaExplorer", 600);
        video2.AddComment(new Comment("MermaidLover", "This is breathtakingly beautiful!"));
        video2.AddComment(new Comment("DiverDan", "I've seen some of these creatures on my dives."));
        video2.AddComment(new Comment("OceanProtector", "Let's all do our part to protect the oceans."));
        video2.AddComment(new Comment("BeachBum", "I could watch this all day."));
        video2.AddComment(new Comment("SharkFan", "Sharks are such misunderstood creatures."));
        video2.AddComment(new Comment("CoralReef", "The coral colors are so vibrant."));

        Video video3 = new Video("Mastering the Art of French Cooking", "ChefJulienne", 860);
        video3.AddComment(new Comment("FoodieFan", "These recipes are divine!"));
        video3.AddComment(new Comment("BakingAddict", "The pastries section was my favorite."));
        video3.AddComment(new Comment("CulinaryStudent", "I learned so much from this, thank you!"));
        video3.AddComment(new Comment("GourmetGuru", "The presentation tips are top-notch."));
        video3.AddComment(new Comment("HealthyEater", "Do you have low-carb French recipes?"));
        video3.AddComment(new Comment("WineLover", "A video on pairing wine with these dishes would be great!"));

        Video video4 = new Video("Journey Through the Amazon Rainforest", "WildAdventurer", 9400);
        video4.AddComment(new Comment("NatureFanatic", "The diversity of life here is astounding."));
        video4.AddComment(new Comment("EcoWarrior", "We must fight to preserve these places."));
        video4.AddComment(new Comment("BirdWatcher", "The bird species you showcased are stunning."));
        video4.AddComment(new Comment("HikingEnthusiast", "Makes me want to plan a trip there!"));
        video4.AddComment(new Comment("Conservationist", "Education on these topics is so important."));
        video4.AddComment(new Comment("JungleExplorer", "I've been here and it's truly a magical place."));

        Video video5 = new Video("The Evolution of Video Games", "GameMaster", 963000);
        video5.AddComment(new Comment("RetroGamer", "The nostalgia is real with this one."));
        video5.AddComment(new Comment("NextGenPlayer", "It's amazing to see how far we've come."));
        video5.AddComment(new Comment("IndieDev", "Inspiring for us smaller developers."));
        video5.AddComment(new Comment("ArcadeFan", "Miss the simplicity of arcade games."));
        video5.AddComment(new Comment("TechGeek", "The advancement in graphics is just mind-blowing."));
        video5.AddComment(new Comment("GameCollector", "I have some of the classics you mentioned."));

        List<Video> videos = new List<Video> {video1, video2, video3, video4, video5};

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine("**************");
            video.DisplayVideo();
            video.Displaycomments();
        }
    }
}