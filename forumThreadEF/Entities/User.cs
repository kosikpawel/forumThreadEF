namespace forumThreadEF.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public List<Post> UserPosts { get; set; }
        public List<Vote> votes { get; set; }
    }
}
