namespace FormulariosAPI.Modules.Auth.Dtos;

public class RegistrationRequest
{
    public string Nombre { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Rol { get; set; } = string.Empty;

}