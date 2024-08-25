using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionBibliotecaMVC.Models
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaID { get; set; }

        [StringLength(100, ErrorMessage = "El nombre debe contener máximo 100 caracteres")]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; } = string.Empty;

        public ICollection<Libro>? Libro { get; set; }
    }
}
