﻿namespace forumThreadEF.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public int PostId { get; set; }
    }
}
