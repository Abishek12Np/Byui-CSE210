public class Video {
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds) {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        this.comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText) {
        comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumberOfComments() {
        return comments.Count;
    }

    public void DisplayDetails() {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {lengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments) {
            Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
        }
        Console.WriteLine();
    }
}
