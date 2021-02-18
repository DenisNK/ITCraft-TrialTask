using ITCraft_TrialTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCraft_TrialTask.Configurations
{
   
    class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.ToTable(User);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(p => p.Active)
                .HasDefaultValue(false);
        }
    }
}
