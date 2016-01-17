namespace Vending_Machine_Kata.Product
{
    public class Products
    {
        private static Cola ColaInstance { get; set; }
        private static Candy CandyInstance { get; set; }
        private static Chips ChipsInstance { get; set; }

        public static Cola Cola => ColaInstance ?? (ColaInstance = new Cola());
        public static Candy Candy => CandyInstance ?? (CandyInstance = new Candy());
        public static Chips Chips => ChipsInstance ?? (ChipsInstance = new Chips());
    }
}