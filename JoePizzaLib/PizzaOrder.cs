namespace JoePizzaLib
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }

        public PizzaOrder(int id, string pizza, int qty, double totAmt)
        {
            Id = id;
            PizzaName = pizza;
            Quantity = qty;
            TotalAmount = totAmt;
        }
        public string OrderInfo()
        {
            return $"Your order id is {Id},You have ordered for {Quantity} {PizzaName} pizzas. Your Total is {TotalAmount}";
        }
    }
}
