using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video prankster = new Video("Dumptruck Honk", "Ben Badboy", 500);
        Comment comment1 = new Comment("Darren", "Wow, that was definitely something");
        Comment comment2 = new Comment("Delilah", "You kids have no respect.");
        Comment comment3 = new Comment("Joe", "Clik on my profle and get robux!");
        prankster.AddComment(comment1);
        prankster.AddComment(comment2);
        prankster.AddComment(comment3);

        Video tutorial = new Video("Woodworking is relaxing", "Frank Fununcle", 300);
        Comment comment4 = new Comment("Anna", "I love the color of oak!");
        Comment comment5 = new Comment("Jeremy", "This answered a question I've had for a long time, thank you.");
        Comment comment6 = new Comment("Bean1245", "Top comment");
        tutorial.AddComment(comment4);
        tutorial.AddComment(comment5);
        tutorial.AddComment(comment6);

        Video newsStory = new Video("The Ongoing Conflict in Owlanding", "Channel 222W", 400);
        Comment comment7 = new Comment("Delilah", "Back in my day, this would never have happened.");
        Comment comment8 = new Comment("Steven", "I've been to Owlanding before, shame to see what's going on");
        Comment comment9 = new Comment("Anonymous", "[Deleted for violation of platform guidlines]");
        newsStory.AddComment(comment7);
        newsStory.AddComment(comment8);
        newsStory.AddComment(comment9);

        prankster.DisplayInfo();
        tutorial.DisplayInfo();
        newsStory.DisplayInfo();

    }
}