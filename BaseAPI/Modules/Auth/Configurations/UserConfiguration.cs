using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BaseAPI.Modules.Auth.Entities;

namespace BaseAPI.Modules.Auth.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

        var hasher = new PasswordHasher<ApplicationUser>();

        builder.ToTable("Users");

        builder.HasData(
                new ApplicationUser
                {
                    Id = "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                    Email = "admin@locahost.com",
                    NormalizedEmail = "admin@locahost.com",
                    Nombre = "Admin",
                    Apellidos = "San Martin",
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    PasswordHash = hasher.HashPassword(null, "BaseAPI2026$"),
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    Id = "294d249b-9b57-48c1-9689-11a91abb6447",
                    Email = "juanperez@locahost.com",
                    NormalizedEmail = "juanperez@locahost.com",
                    Nombre = "Juan",
                    Apellidos = "Perez",
                    UserName = "juanperez",
                    NormalizedUserName = "juanperez",
                    PasswordHash = hasher.HashPassword(null, "BaseAPI2026$"),
                    EmailConfirmed = true,
                }
            );


    }
}
