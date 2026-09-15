using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ML_PROY_BACKEND.Data;
using ML_PROY_BACKEND.Dto.Usuario;
using ML_PROY_BACKEND.Exceptions;
using ML_PROY_BACKEND.Services.Interfaces;

namespace ML_PROY_BACKEND.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ApiContext _context;

        public UsuarioService(ApiContext context)
        {
            _context = context;
        }

        public async Task<LoginRes> LoginAsync(LoginReq req)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.LogUsu == req.LogUsu);

            if (usuario == null)
            {
                throw new NotFoundException("Usuario no encontrado.");
            }

            if (usuario.PasUsu != req.PasUsu)
            {
                throw new BadRequestException("Contraseña incorrecta.");
            }

            return new LoginRes
            {
                Mensaje = "Credenciales correctas",
                Rol = usuario.RolUsu
            };
        }
    }
}
