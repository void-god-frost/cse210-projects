using System;
using System.Reflection;
using Microsoft.VisualBasic;

public class Youtube
{
    private List<Video> _videos;

    public Youtube()
    {
        _videos = new List<Video>();
    }

    public void AddVideo(string title, float length)
    {
        Video video = new Video(title, length);
        _videos.Add(video);
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine("Comment Count: {0}", video.CountComments());
            Console.WriteLine();
        }
    }
    public void AddCommentToVideo(string videoTitle, string author, string commentText)
    {
        foreach (Video video in _videos)
        {
            if (video.GetTitleOfVideo() == videoTitle)
            {
                video.AddComment(author, commentText);
                return;
            }
        }
    }
}