using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoDanielMeton.Domain;
using ProjetoDanielMeton.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjetoDaniel
{
    [TestClass]
    public class UnitTestOrder
    {
        [TestMethod]
        public void TestListOrder()
        {
            Order order = new Order();
            Assert.AreEqual("Cafe", order.Orders(1,"3"));
        }
        [ExpectedException(typeof(System.InvalidOperationException))]
        [TestMethod]
        public void TestListOrderError()
        {
            Order order = new Order();
            Assert.AreEqual("Cafe", order.Orders(5, "3"));
        }
        [TestMethod]
        public void TestListOrderMorning()
        {
            Order order = new Order();
            CollectionAssert.AreEqual(new List<Dish>() { Dish.Ovos,Dish.Cafe,Dish.Cafe }, order.OrderMorning(new List<int>() { 1,3,3 }));
        }
        [TestMethod]
        public void TestListOrderNight()
        {
            Order order = new Order();
            CollectionAssert.AreEqual(new List<Dish>() { Dish.Carne, Dish.Batata, Dish.Vinho }, order.OrderNight(new List<int>() { 1, 2, 3 }));
        }
        [ExpectedException(typeof(System.InvalidOperationException))]
        [TestMethod]
        public void TestListOrderNightError()
        {
            Order order = new Order();
            CollectionAssert.AreEqual(new List<Dish>() { Dish.Carne, Dish.Batata, Dish.Vinho }, order.OrderNight(new List<int>() { 1, 3, 3 }));
        }
    }
}
