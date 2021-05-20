using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoMVC.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        [StringLength(300)]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        public Categoria Categorias { get; set; }
        public int CategoriaId { get; set; }


    }
}
