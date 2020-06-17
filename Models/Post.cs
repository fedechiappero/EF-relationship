using testDotnet.Models;
using System.Text.Json.Serialization;

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    // relationship config
    public int BlogId { get; set; } // foreign key
    //[JsonIgnore]
    //public Blog Blog { get; set; } // navigation property
}