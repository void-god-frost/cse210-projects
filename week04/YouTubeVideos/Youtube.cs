using System;

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

    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }
    }
}