using Lesson004_JWTToken.DTO;
using Lesson004_JWTToken.Entities;
using Lesson004_JWTToken.ServiceContracts;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Lesson004_JWTToken.Services
{
    public class JwtService : IJwtService
    {
        IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AppResponse CreateJwtToken(AppUser user)
        {
            DateTime expiration = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:EXPIRATION_MINUTES"]));



            Claim[] claims = new Claim[] {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()), //Subject for user id
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),//ensures to create unique JWt token, unique param
                new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),//time for th jwt 
                new Claim(ClaimTypes.NameIdentifier,user.Email??""),
                new Claim(ClaimTypes.Name,user.PersonName ?? ""),

            };


            SymmetricSecurityKey securityKey = new
                SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            SigningCredentials signingCredentials = new SigningCredentials
                (securityKey,SecurityAlgorithms.HmacSha256);


            JwtSecurityToken tokenGenerator = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                expires:expiration,
                signingCredentials: signingCredentials
                
                );


            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            string token = tokenHandler.WriteToken(tokenGenerator);
            string refreshToken = GenerateRefreshToken();
            DateTime refreshTokenExpirationDateTime = DateTime.Now.AddMinutes(
                    Convert.ToInt32(_configuration["RefreshToken:EXPIRATION_MINUTES"])
                );

            return new AppResponse
            {
                Token = token,
                Email = user.Email,
                Expiration = expiration,
                PersonName = user.PersonName,
                RefreshToken = refreshToken,
                RefreshTokenExpirationDateTime = refreshTokenExpirationDateTime
            };

        }

        public string GenerateRefreshToken()
        {
            byte[] bytes = new byte[64];
            var randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}
