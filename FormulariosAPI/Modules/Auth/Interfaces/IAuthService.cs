using ErrorOr;
using FormulariosAPI.Modules.Auth.Dtos;

namespace FormulariosAPI.Modules.Auth.Interfaces;

public interface IAuthService
{
    Task<ErrorOr<AuthResponse>> Login(AuthRequest request);
    Task<ErrorOr<RegistrationResponse>> Register(RegistrationRequest request);
}
