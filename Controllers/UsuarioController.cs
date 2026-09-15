using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ML_PROY_BACKEND.Dto.Usuario;
using ML_PROY_BACKEND.Services.Interfaces;

namespace ML_PROY_BACKEND.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginReq req)
        {
            var result = await _usuarioService.LoginAsync(req);
            return Ok(result);
        }
    }
}
