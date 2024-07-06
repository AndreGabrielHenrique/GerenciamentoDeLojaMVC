using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeLojaMVC.Models
{
    public class Produto
    {
        [Key]
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Marca{get;set;}
        public decimal Preco{get;set;}
        public DateTime? Validade{get;set;}
    }
}