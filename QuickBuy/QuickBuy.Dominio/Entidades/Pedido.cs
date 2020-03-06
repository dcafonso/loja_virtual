using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } // Relacionamento com do pedido com o usuário
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string NroEndereco { get; set; }
        public int FormaPagtoId { get; set; }
        public FormaPagto FormaPagto { get; set; }

        /// <summary>
        /// Pedido deve ter ao menos 1 item de pedido
        /// ou muitos itens de pedido.
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (ItensPedido.Any())
            {
                MensagemValidacao.Add("O Pedido não pode ficar sem item de pedido!");
            }
        }
    }
}
