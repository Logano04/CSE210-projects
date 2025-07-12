class Videos
{
    public List<Video> videosList;

    public Videos()
    {
        videosList = new List<Video>();
    }

    public void Run()
    {
        Video video1 = new Video("How to make a bomb", "Ted Kazynski", 322);
        video1.createComment("Vile Shlomo", "This seems a little illegal");
        video1.createComment("bomberman", "thanks, really helpful");
        video1.createComment("Dale Dalington", "Instructions unclear, I made a fridge");
        video1.createComment("Timmy Jones", "I'm gonna win the science fair with this, thanks");
        videosList.Add(video1);
        Video video2 = new Video("How I accidentally married a beaver (NOT CLICKBAIT)", "Venleigh Vlogz", 604);
        video2.createComment("ashleigh", "can I come to the housewarming party for his dam?");
        video2.createComment("Bob Hughes", "this is disgraceful");
        video2.createComment("Barry Beaverton", "why him and not me... :(");
        video2.createComment("Allen", "This happened to my buddy eric back in '08");
        videosList.Add(video2);
        Video video3 = new Video("Ranking my children", "Momma Jones", 543);
        video3.createComment("Tiffaneigh", "This seems a little mean...");
        video3.createComment("Bob Hughes", "Have them compete in combat to increase their ranking");
        video3.createComment("Timmy Jones", "Why did you put me at the bottom");
        videosList.Add(video3);
        Video video4 = new Video("NEWS: Woodcrest elementary in flames after science fair explosion", "L6News", 212);
        video4.createComment("Tiffaneigh", "Aw, that's terrible :(. At least no one was killed.");
        video4.createComment("Timmy Jones", "My bad");
        video4.createComment("Allen", "My buddy eric did the same thing back in '02");
        videosList.Add(video4);
    }
    public void orderVideos()
    {
        foreach (Video video in videosList)
        {
            Console.WriteLine(video.videoTitle);
            Console.WriteLine($"  by {video.videoAuthor} - {video.lengthInSeconds} seconds");
            Console.WriteLine("--------");
            Console.WriteLine($"{video.returnCommentCount()} Comments:");
            foreach (Comment comment in video.commentsList)
            {
                Console.WriteLine(comment.commenter);
                Console.WriteLine($"  {comment.content}");
            }
            Console.WriteLine("");
        }
    }
}