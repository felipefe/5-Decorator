namespace Name
{
    public class Program
    {
       public static void Main(string[] args)
       {
          Cafe c = new CafeExpresso();
          System.Console.WriteLine(c.GetItem());

          var op1 = new OpcionalChocolate(c);
          System.Console.WriteLine(op1.GetItem());
       }
    }
}