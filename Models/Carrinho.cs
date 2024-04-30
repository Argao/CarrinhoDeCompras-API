using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoDeCompras_API.Models
{
    public class Carrinho
    {
        public int Id { get; set; } 
        public decimal ValorTotal { get; set; }


        public Pessoa pessoa{ get; set; }
        
        public ICollection<Produto> Produtos { get; set; }
        
    }
}