namespace PersonalBlog.Models
{
    public class Repo : IRepository<Post>
    {
        public List<Post> GetData()
        {
            return new List<Post>();
        }

        public List<Post> SetData(Post data)
        {
            return new List<Post>();
        }
    }
}
