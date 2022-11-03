using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forumThreadEF.Entities.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne(p => p.PostType)
                .WithMany()
                .HasForeignKey(p => p.PostTypeId);

            builder.HasOne(p => p.User)
                .WithMany(u => u.UserPosts)
                .HasForeignKey(p => p.UserID);
        }
    }
}
