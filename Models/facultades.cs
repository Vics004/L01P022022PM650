using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PM650.Models
{
    public class facultades
    {
        [Key]
        [DisplayName("ID de la Facultad")]
        public int id { get; set; }
        [DisplayName("Nombre de la facultad")]
        [Required(ErrorMessage = "NO es opcional")]
        public string? facultad {  get; set; }

    }
}
