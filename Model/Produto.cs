using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1Bim.Model
{
    public class Produto
    {
        [Key]
        [Required]
        public int IdProduto { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public int QtdMin { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public double Tamanho { get; set; }
        [Required]
        public string Cor { get; set; }
    }
}
