using System.ComponentModel.DataAnnotations;

namespace ML_PROY_BACKEND.Dto.Usuario
{
    public class LoginReq
    {
        [Required]
        public string LogUsu { get; set; } = string.Empty;

        [Required]
        public string PasUsu { get; set; } = string.Empty;
    }
}
