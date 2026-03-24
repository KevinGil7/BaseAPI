using ErrorOr;
using BaseAPI.Modules.Auth.Dtos;

namespace BaseAPI.Modules.Auth.Interfaces;

public interface IAuthService
{
    Task<ErrorOr<AuthResponse>> Login(AuthRequest request);
    Task<ErrorOr<RegistrationResponse>> Register(RegistrationRequest request);
}
