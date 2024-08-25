using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionBibliotecaMVC.Models
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutorID { get; set; }

        [StringLength(100, ErrorMessage = "El nombre debe contener máximo 100 caracteres")]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "El apellido debe contener máximo 100 caracteres")]
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo apellido es requerido")]
        public string Apellido { get; set; } = string.Empty;
    }
}
