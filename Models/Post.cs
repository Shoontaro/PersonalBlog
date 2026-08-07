using System.Security.Cryptography.X509Certificates;

namespace PersonalBlog.Models
{
    public class Post
    {
        public string? Title { get; set; }
        public string? Body { get; set; }
        public DateTime Date { get; set; }
        public int? PostId { get; set; }

        public Post() { }
        public Post(string title, string body)
        { 
            Title = title; Body = body; Date = DateTime.Now;
        }
        public Post(string title, string body, DateTime date):this(title, body) {
            Date = date;
        }

        public static List<Post> Seeds() 
        {
            return new List<Post>() {
                new Post("First", ""),
                new Post("Second", ""),
                new Post("Third", ""),
                new Post("Fourth", "")
            };
        }
    }
}
