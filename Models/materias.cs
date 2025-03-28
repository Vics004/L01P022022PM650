using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PM650.Models
{
    public class materias
    {
        [Key]
        [DisplayName("ID de la materia")]
        public int id { get; set; }
        [DisplayName("Nombre de la materia")]
        [Required(ErrorMessage = "NO es opcional")]
        public string? materia { get; set; }
        [DisplayName("Unidades Valorativas")]
        [Required(ErrorMessage = "NO es opcional")]
        [Range(0, 10, ErrorMessage = "Solo Permite numeros del 0 al 10")]
        public int unidades_valorativas { get; set; }
        [DisplayName("Estado de la materia")]
        [Required(ErrorMessage = "NO es opcional")]
        [StringLength(1, ErrorMessage ="La cantidad maxima de caracteres valida es {1}")]
        public string? estado { get; set; }
    }
}
