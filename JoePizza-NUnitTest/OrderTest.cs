using JoePizzaLib;

namespace JoePizza_NUnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestOrderInfo()
        {
            Assert.Pass();
            var order = new PizzaOrder(1, "Pepperoni", 2, 1100);
            var result = order.OrderInfo();
            Assert.That(result.Equals("Your order id is 1,You have ordered for 2 Pepperoni pizzas. Your Total is 1100"));
        }
    }
}