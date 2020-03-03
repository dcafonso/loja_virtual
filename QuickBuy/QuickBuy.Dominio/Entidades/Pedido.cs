﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public int FormaPagtoId { get; set; }
        public FormaPagto FormaPagto { get; set; }

        /// <summary>
        /// Pedido deve ter ao menos 1 item de pedido
        /// ou muitos itens de pedido.
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
