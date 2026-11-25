using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment = new Comment("Olumide Ogunyemi", "First Comment");
        Console.WriteLine(comment.GetComment());
        
        Youtube youtube = new Youtube();
        youtube.AddVideo("Emmanuel is a bad boy", 13.99f);
        youtube.AddVideo("You can be Better", 45.99f);
        youtube.AddVideo("Olumide Loves Coding", 22.00f);
        youtube.AddVideo("I can fly", 10.00f);
        youtube.AddVideo("GTA 6 Gameplay", 16.56f);
        youtube.AddVideo("Bike Riders", 30.00f);
        youtube.AddVideo("Fire Fighters", 25.25f);
        youtube.DisplayVideos();
    }
}