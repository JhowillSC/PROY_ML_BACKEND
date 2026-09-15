using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ML_PROY_BACKEND.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("id_usu")]
        public int IdUsu { get; set; }

        [Column("log_usu")]
        [MaxLength(255)]
        public string LogUsu { get; set; } = string.Empty;

        [Column("pas_usu")]
        [MaxLength(255)]
        public string PasUsu { get; set; } = string.Empty;

        [Column("fec_usu")]
        public DateTime FecUsu { get; set; }

        [Column("fec_mod")]
        public DateTime? FecMod { get; set; }

        [Column("rol_usu")]
        [MaxLength(1)]
        public string RolUsu { get; set; } = string.Empty;
    }
}
