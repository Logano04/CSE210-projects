using System;

class Program
{
    static void Main(string[] args)
    {
        Videos videos = new Videos();
        videos.Run();
        videos.orderVideos();
    }
}