using System.Diagnostics;

namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public class TestInitAndCleanUp
    {
        private ShoppingCart cart;
        private Item item;
        [TestInitialize]
        public void TestInitialize()
        {
            const int quantity = 10;
            Debug.WriteLine("Test initialize");
            item = new Item("UnitTesting", quantity);
            cart = new ShoppingCart();
            cart.Add(item);
        }
        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CLeanUp");
            cart.Dispose();
        }
        [TestMethod]
        public void ShoppingCart_Chekout_ContainsItem()
        {
            CollectionAssert.Contains(cart.Items, item);
        }
        [TestMethod]
        public void ShoppingCart_RemoveItem_Empty()
        {
            int expected = 0;
            cart.Remove(0);
            Assert.AreEqual(expected, cart.Count);
        }

    }
}