using Microsoft.AspNetCore.Mvc;
using GerenciamentoDeLojaMVC.Data;
using GerenciamentoDeLojaMVC.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeLojaMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ListaDeProdutos _listaDeProdutos;

        public ProdutoController(ListaDeProdutos listaDeProdutos)
        {
            _listaDeProdutos = listaDeProdutos;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nome, string marca, decimal preco, DateTime validade)
        {
            _listaDeProdutos.AdicionarProduto(new Produto { Nome = nome, Marca = marca, Preco = preco, Validade = validade });
            return RedirectToAction("Index");
        }
    }
}
