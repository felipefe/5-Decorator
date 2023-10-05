namespace Name
{
    public class OpcionalChocolate : OpcionalDecorator
    {

        public OpcionalChocolate(Cafe c)
        {
            this.Cafe = c;
            this.Descricao = " com Chocolate";
            this.Preco = 5.50m;
        }

        public override string GetItem()
        {
            return $"Item: {Cafe.Descricao + this.Descricao} R${Cafe.Preco + this.Preco}";
        }
    }
}