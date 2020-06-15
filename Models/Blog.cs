using testDotnet.Models;
using System.Collections.Generic; // for Lists


public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    
    // relationship config
    public List<Post> Posts { get; set; } // navigation property
}