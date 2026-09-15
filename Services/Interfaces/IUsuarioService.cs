using System.Threading.Tasks;
using ML_PROY_BACKEND.Dto.Usuario;

namespace ML_PROY_BACKEND.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<LoginRes> LoginAsync(LoginReq req);
    }
}
