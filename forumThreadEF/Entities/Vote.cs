namespace forumThreadEF.Entities
{
    public class Vote
    {
        public int Value { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}
