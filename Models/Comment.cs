public class Comment
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set; }

    public Post Post { get; set; }
}