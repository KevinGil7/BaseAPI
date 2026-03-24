using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BaseAPI.Modules.Auth.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.ToTable("Role");

        builder.HasData(
            new IdentityRole
            {
                Id = "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },

            new IdentityRole
            {
                Id = "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                Name = "Evaluador",
                NormalizedName = "Evaluador"
            }
        );
    }
}
