namespace JoePizzaTestSpecFlow.StepDefinitions
{
    [Binding]
    public class OrderStepDefinitions
{
        int pizzaPrice;
        int totalAmount;

        [Given(@"the customer has selected two Farm House pizzas with price Rs.(\d+)")]
        public void GivenTheCustomerHasSelectedAPizzaWithPrice(int price)
        {
            pizzaPrice = price;
        }

        [When(@"the customer checks the total amount")]
        public void WhenTheCustomerChecksTheTotalAmount()
        {
            totalAmount = pizzaPrice * 2;
        }

        [Then(@"the total amount should be Rs.(\d+)")]
        public void ThenTheTotalAmountShouldBe(int expectedTotal)
        {
            Assert.Equal(expectedTotal, totalAmount);
        }
    }
}