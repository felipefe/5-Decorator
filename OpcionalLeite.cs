namespace Name
{
    public class OpcionalLeite : OpcionalDecorator
    {

        public OpcionalLeite(Cafe c)
        {
            this.Cafe = c;
            this.Descricao = " com Leite";
            this.Preco = 2.50m;
        }

        public override string GetItem()
        {
            return $"Item: {Cafe.Descricao + this.Descricao} R${Cafe.Preco + this.Preco}";
        }
    }
}