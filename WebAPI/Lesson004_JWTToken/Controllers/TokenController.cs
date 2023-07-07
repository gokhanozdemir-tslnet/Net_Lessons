using Lesson004_JWTToken.DTO;
using Lesson004_JWTToken.Entities;
using Lesson004_JWTToken.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson004_JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        IJwtService _jwtservice;

        public TokenController(IJwtService jwtservice)
        {
            _jwtservice = jwtservice;
        }



 
        [HttpPost]
        [Produces("application/json")]
        public async Task<ActionResult<AppResponse>> Get(AppUser user)
        {
            var response = _jwtservice.CreateJwtToken(user);
           
            return response;
        }
    }
    
}
