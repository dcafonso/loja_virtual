﻿using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Usuário poder ter nenhum ou vários pedidos.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Email))
            {
                MensagemValidacao.Add("Usuário deve ser preenchido!");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                MensagemValidacao.Add("Senha deve estar preenchida!");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                MensagemValidacao.Add("Nome deve estar preenchido!");
            }
        }
    }
}
