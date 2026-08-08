using System.Security.Cryptography.X509Certificates;

namespace PersonalBlog.Models
{
    public class Post
    {
        public string? Title { get; set; }
        public string? Body { get; set; }
        public DateTime Date { get; set; }
        public string? PostId { get; set; }

        public Post() { }
        public Post(string title, string body)
        { 
            Title = title; Body = body; Date = DateTime.Now;
        }

        public Post(string title, string body, DateTime date):this(title, body) {
            Date = date;
        }

        public static List<Post> GetPosts()
        {
            return new List<Post>();
        }

        public static Post GetPost(string id)
        {
            return Seeds().Find(v=>v.PostId == id);
            //return new Post();
        }

        public static List<Post> Seeds() 
        {
            return new List<Post>() {
                new Post("First", ""){ PostId = "1"},
                new Post("Second", ""){ PostId = "2"},
                new Post("Third", ""){ PostId = "3"},
                new Post("Fourth", ""){ PostId = "4"}
            };
        }
    }
}
