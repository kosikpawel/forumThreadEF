using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forumThreadEF.Entities.Configurations
{
    public class VoteConfigration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        { 
            builder.HasKey(v => new { v.UserId, v.PostId });
        }
    }
}
