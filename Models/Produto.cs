using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoDeCompras_API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }

        public List<Carrinho> Carrinhos { get; } = [];

    }
}