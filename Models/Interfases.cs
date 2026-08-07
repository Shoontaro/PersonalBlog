namespace PersonalBlog.Models
{
    public interface IRepository<T>
    {
        public List<T> GetData();
        public List<T> SetData(T data);
    }
}
