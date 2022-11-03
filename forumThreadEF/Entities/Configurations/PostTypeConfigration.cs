using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forumThreadEF.Entities.Configurations
{
    public class PostTypeConfigration : IEntityTypeConfiguration<PostType>
    {
        public void Configure(EntityTypeBuilder<PostType> builder)
        {
            builder.HasData(
                new PostType() { Id = 1, Type = "Question"},
                new PostType() { Id = 2, Type = "Answer"}
                );

            builder.Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
