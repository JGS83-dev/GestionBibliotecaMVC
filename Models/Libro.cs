using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionBibliotecaMVC.Models
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibroID { get; set; }

        [StringLength(200, ErrorMessage = "El titulo debe contener máximo 200 caracteres")]
        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "El campo titulo es requerido")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Fecha de Publicación")]
        [Required(ErrorMessage = "El campo fecha de publicación es requerido")]
        public DateTime FechaPublicacion { get; set; }

        [Required]
        [ForeignKey("Autor")]
        [Display(Name = "Autor")]
        public string? AutorID { get; set; }

        public Autor? Autor { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public string? CategoriaID { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
