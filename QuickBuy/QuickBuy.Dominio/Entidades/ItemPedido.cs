namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Qtde { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (ProdutoId == 0)
            {
                MensagemValidacao.Add("Id do Produto deve ser preenchido!");
            }

            if (Qtde < 1)
            {
                MensagemValidacao.Add("Quantidade Inválida!");
            }
        }
    }
}
