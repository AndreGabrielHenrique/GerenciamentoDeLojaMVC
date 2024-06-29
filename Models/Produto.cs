using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeLojaMVC.Data;

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

        public void AdicionarProduto(ApplicationDbContext context)
        {
            context.Produtos.Add(this);
            context.SaveChanges();
        }

        public static List<Produto> ListarProdutos(ApplicationDbContext context)
        {
            return context.Produtos.ToList();
        }

        public void AtualizarProduto(ApplicationDbContext context)
        {
            context.Produtos.Update(this);
            context.SaveChanges();
        }

        public static void ExcluirProduto(int id, ApplicationDbContext context)
        {
            var produto = context.Produtos.Find(id);
            if (produto != null)
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
            }
        }
    }
}