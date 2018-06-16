namespace BlogCourse.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //Navigation
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}