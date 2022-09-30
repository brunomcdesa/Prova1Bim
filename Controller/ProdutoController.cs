using Microsoft.AspNetCore.Mvc;
using Prova1Bim.Data;
using Prova1Bim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1Bim.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private ProdutoContext _context;
        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Produto> GetProdutos()
        {
            return _context.produtos;
        }
        [HttpGet("{id}")]
        public IActionResult GetProdutoById(int id)
        {
            Produto produto = _context.produtos.FirstOrDefault(produto => produto.IdProduto == id);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult PostProduto([FromBody] Produto produto) 
        {
            if(produto.Preco <= 0.01)
            {
                return NotFound();
            }
            else
            {
                _context.produtos.Add(produto);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetProdutoById), new {Id = produto.IdProduto}, produto);
            }
        
        }
    }
}
