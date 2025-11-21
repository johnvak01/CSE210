using System;

class Program
{
    static void Main(string[] args)
    {
        // make comments
        Comment comment1 = new Comment("user1","FIIRST!");
        Comment comment2 = new Comment("user2","LAAAME!!");
        Comment comment3 = new Comment("user3","AMAAZE!!!");
        Comment comment4 = new Comment("user4","COOOOL!!!!");
        Comment comment5 = new Comment("user5","SWEEET!!!!!");
        Comment comment6 = new Comment("user6","BANNED!!!!!!");
        // make videos
        Video video1 = new Video("Video 1", "John Doe", 300, [comment1, comment2, comment3]);
        Video video2 = new Video("Video 2", "Mario Rossi", 600, [comment4, comment5, comment6]);

        // display
        Console.WriteLine(video1.DisplayVideo() + "\n" + video1.DisplayComments());
        Console.WriteLine(video2.DisplayVideo() + "\n" + video2.DisplayComments());
    }
}