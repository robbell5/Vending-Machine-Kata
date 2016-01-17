namespace Vending_Machine_Kata.Product
{
    public class Products
    {
        private static Cola ColaInstance { get; set; }

        public static Cola Cola => ColaInstance ?? (ColaInstance = new Cola());

        public static object Chips => new Chips();
        public static object Candy => new Candy();
    }
}