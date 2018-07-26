using ProjetoDanielMeton.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielMeton.Domain
{
    public class Menu
    {
        public List<Dish> ListEntrada()
        {
            return new List<Dish>() { Dish.Ovos, Dish.Carne };
        }
        public List<Dish> ListAcompanhamentos()
        {
            return new List<Dish>() { Dish.Torrada, Dish.Batata };
        }
        public List<Dish> ListBebida()
        {
            return new List<Dish>() { Dish.Cafe, Dish.Vinho };
        }
        public List<Dish> ListSobremesa()
        {
            return new List<Dish>() { Dish.Bolo };
        }
    }
}
