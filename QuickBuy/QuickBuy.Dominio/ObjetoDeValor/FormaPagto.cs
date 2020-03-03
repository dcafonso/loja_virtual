using QuickBuy.Dominio.Enums;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto
        {
            get { return Id == (int)TipoFormaPagtoEnum.Boleto; }
        }

        public bool IsCartaoCredito
        {
            get { return Id == (int)TipoFormaPagtoEnum.CartaoCredito; }
        }

        public bool IsDeposito
        {
            get { return Id == (int)TipoFormaPagtoEnum.Deposito; }
        }

        public bool IsNaoDefinido
        {
            get { return Id == (int)TipoFormaPagtoEnum.NaoDefinido; }
        }
    }
}
