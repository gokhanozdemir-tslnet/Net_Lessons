using Lesson004_JWTToken.DTO;
using Lesson004_JWTToken.Entities;

namespace Lesson004_JWTToken.ServiceContracts
{
    public interface IJwtService
    {
        AppResponse CreateJwtToken(AppUser user);
    }
}
