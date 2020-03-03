using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int NroEndereco { get; set; }

        /// <summary>
        /// Usuário poder ter nenhum ou vários pedidos.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
