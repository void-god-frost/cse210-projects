using System;
using System.Diagnostics.Metrics;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        Youtube youtube = new Youtube();
        youtube.AddVideo("Emmanuel is a bad boy", 13.99f);
        youtube.AddCommentToVideo("Emmanuel is a bad boy", "Raphael", "I know right");

        youtube.AddVideo("You can be Better", 45.99f);
        youtube.AddCommentToVideo("You can be Better", "Riski", "Yessssssss");

        youtube.AddVideo("Olumide Loves Coding", 22.00f);
        youtube.AddCommentToVideo("Olumide Loves Coding", "Olumide", "Of Course, Why wouldn't I? 😜");

        youtube.AddVideo("I can fly", 10.00f);
        youtube.AddCommentToVideo("I can fly", "Ogoluwa", "Are you sure? 😂");
        youtube.AddCommentToVideo("I can fly", "Olumide", "Bro is propably gonna kill himself");

        youtube.AddVideo("GTA 6 Gameplay", 16.56f);
        youtube.AddCommentToVideo("GTA 6 Gameplay", "Raphael", "Tell Me about it! 🙄");
        youtube.AddCommentToVideo("GTA 6 Gameplay", "Olumide", "Bird Man 😂😭");

        youtube.AddVideo("Bike Riders", 30.00f);
        youtube.AddCommentToVideo("Bike Riders", "Olumide", "They're so fast tho");

        youtube.AddVideo("Fire Fighters", 25.25f);
        youtube.AddCommentToVideo("Fire Fighters", "Raphael", "Fireeeeeeeee🔥");

        youtube.DisplayVideos();

    }
}