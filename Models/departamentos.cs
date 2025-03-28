using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PM650.Models
{
    public class departamentos
    {
        [Key]
        [DisplayName("ID del Departamento")]
        public int id { get; set; }
        [DisplayName("Nombre de los departamentos")]
        [Required(ErrorMessage = "NO es opcional")]
        public string? departamento { get; set; }

    }
}