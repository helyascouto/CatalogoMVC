using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O campo nome e Obrigatório!")]
        [MaxLength(80)]
        public string Nome { get; set; }
<<<<<<< Updated upstream
 
=======
        [Required]
        [MaxLength(300)]
        public string ImagemUrl { get; set; }

       
>>>>>>> Stashed changes
    }
}
