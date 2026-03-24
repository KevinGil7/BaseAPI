using Microsoft.AspNetCore.Identity;

namespace BaseAPI.Modules.Auth.Entities;

public class ApplicationUser : IdentityUser
{
    public string Nombre { get; set; } = "";

    public string Apellidos { get; set; } = "";
}