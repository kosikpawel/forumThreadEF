namespace forumThreadEF.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public PostType PostType { get; set; }
        public int PostTypeId { get; set; }

        public User User { get; set; }
        public int UserID { get; set; }
    }
}
