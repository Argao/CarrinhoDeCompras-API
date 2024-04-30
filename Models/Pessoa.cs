using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoDeCompras_API.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int CarrinhoId { get; set; }
        public Carrinho Carrinho { get; set; }

    }
}