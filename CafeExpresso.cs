namespace Name
{
    public class CafeExpresso : Cafe
    {
        public CafeExpresso()
        {
            this.Descricao = "Café Expresso";
            this.Preco = 10.5m;
        }

        public override string GetItem()
        {
            return $"Item: {this.Descricao} R${this.Preco}";
        }
    }
}