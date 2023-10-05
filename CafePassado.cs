namespace Name
{
    public class CafePassado : Cafe
    {
        public CafePassado()
        {
            this.Descricao = "Café Passado";
            this.Preco = 8.5m;
        }
        public override string GetItem()
        {
            return $"Item: {this.Descricao} R${this.Preco}";
        }
    }
}