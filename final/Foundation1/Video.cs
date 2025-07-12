using System;

class Video
{
    public string videoTitle;
    public string videoAuthor;
    public int lengthInSeconds;
    public List<Comment> commentsList;

    public Video(string title, string author, int length)
    {
        videoTitle = title;
        videoAuthor = author;
        lengthInSeconds = length;
        commentsList = new List<Comment>();
    }
    public int returnCommentCount()
    {
        int commentCount = 0;
        foreach (Comment comment in commentsList)
        {
            commentCount++;
        }
        return commentCount;
    }
    public void createComment(string author, string content)
    {
        Comment comment = new Comment(author, content);
        commentsList.Add(comment);
    }
}