using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PM650.Models
{
    public class alumnos
    {
        [Key]
        [DisplayName("ID del Alumno")]
        public int id { get; set; }

        [DisplayName("Codigo del Alumno")]
        [Required(ErrorMessage = "NO es opcional")]
        public string? codigo  { get; set; }
        [DisplayName("Nombres del Alumno")]
        [Required(ErrorMessage = "NO es opcional")]
        public string? nombre { get; set; }
        [DisplayName("Apellidos del Alumno")]
        [Required(ErrorMessage = "NO es opcional")]
        public string? apellidos { get; set; }
        [DisplayName("Dui del Alumno")]
        [Required(ErrorMessage = "NO es opcional")]
        public int dui { get; set; }
        [DisplayName("Número de estado del Alumno")]
        [Required(ErrorMessage = "NO es opcional")]
        [Range(0, 1, ErrorMessage = "Solo Permite 0 (No Activo) y 1 (Activo)")]
        public int estado { get; set; }


    }
}
