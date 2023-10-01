using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public class ClassInitAndCleanUp
    {
        private static ShoppingCart cart;
        //Запускається перед стартом першого тестованого методу(один раз)
        //Метод повинен бути відкритим, статичним, та приймати параметр типу TestContext
        [ClassInitialize]
        public static void ClassInitialize()
        {
            Debug.WriteLine("Class Initialize");
            Item item = new Item();
            item.Name = "Class Initialize method of unit testing";
            item.Quantity = 10;

            cart = new ShoppingCart();
            cart.Add(item);
        }
        //Запускається після завершення останнього тестованого методу (один раз)
        //Метод повинен бути відкритим, статичним та повертати void
       
        [TestMethod]
        public void ShoppingCart_AddToCart()
        {
            int expected = cart.Items.Count + 1;
            cart.Add(new Item() { Name = "Test", Quantity = 1 });
            Assert.AreEqual(expected, cart.Count);
        }
        [TestMethod]
        public void ShoppingCart_RemoveFromCart()
        {
            int expected = cart.Items.Count - 1;
            cart.Remove(0);
            Assert.AreEqual(expected, cart.Count);
        }
        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Class CleanUp");
            cart.Dispose();
        }
    }
}
