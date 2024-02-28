namespace JoePizzaLib
{
    public class Order
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }//=> Pizza.Price * Quantity;
    }
}
