using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoDanielMeton.Domain;
using ProjetoDanielMeton.Model;
using System.Collections.Generic;

namespace UnitTestProjetoDaniel
{
    [TestClass]
    public class UnitTestMenu
    {
        [TestMethod]
        public void TestListEntrada()
        {
            Menu menu = new Menu();
            CollectionAssert.AreEqual(new List<Dish>() { Dish.Ovos, Dish.Carne }, menu.ListEntrada());
        }
        [TestMethod]
        public void TestListAcompanhamentos()
        {
            Menu menu = new Menu();
            CollectionAssert.AreEqual(new List<ProjetoDanielMeton.Model.Dish>() { Dish.Torrada, Dish.Batata }, menu.ListAcompanhamentos());
        }
        [TestMethod]
        public void TestListBebida()
        {
            Menu menu = new Menu();
            CollectionAssert.AreEqual(new List<ProjetoDanielMeton.Model.Dish>() { Dish.Cafe, Dish.Vinho }, menu.ListBebida());
        }
        [TestMethod]
        public void TestListSobremesa()
        {
            Menu menu = new Menu();
            CollectionAssert.AreEqual(new List<ProjetoDanielMeton.Model.Dish>() { Dish.Bolo }, menu.ListSobremesa());
        }
    }
}
