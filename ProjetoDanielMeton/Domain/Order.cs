using ProjetoDanielMeton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDanielMeton.Domain
{
    public class Order
    {
        public string Orders(int period, string itens)
        {
            string order = "";
            switch (period)
            {
                case (int)Period.Manha:
                    foreach (Dish dish in OrderMorning(itens.Split(",").Select(Int32.Parse).ToList())){
                        order += dish.ToString() + ",";
                    }
                    return order.Remove(order.Length - 1, 1);

                case (int)Period.Noite:
                    foreach (Dish dish in OrderNight(itens.Split(",").Select(Int32.Parse).ToList())){
                        order += dish.ToString() + ",";
                    }
                    return order.Remove(order.Length - 1, 1);
                default:
                    throw new InvalidOperationException("Periodo Invalido");
            }

        }

        public List<Dish> OrderMorning(List<int> itens)
        {
            Menu menu = new Menu();
            List<Dish> order = new List<Dish>();
            foreach(int item in itens)
            {
                switch (item)
                {
                    case (int)DishType.entrada:
                        if (!order.Contains(menu.ListEntrada()[0]))
                            order.Add(menu.ListEntrada()[0]);
                        else
                            throw new InvalidOperationException("Você não pode selecionar Ovos duas vezes no periodo da manhã");
                        break;
                    case 2:
                        if (!order.Contains(menu.ListAcompanhamentos()[0]))
                            order.Add(menu.ListAcompanhamentos()[0]);
                        else
                            throw new InvalidOperationException("Você não pode selecionar Torrada duas vezes no periodo da manhã");
                        break;
                    case 3:
                        order.Add(menu.ListBebida()[0]);
                        break;
                    default:
                        throw new InvalidOperationException("A opção " + item + " é invalida  \n Opções possíveis: " + String.Join(",",PossibleOrderMorning().AsEnumerable()));

                }
            };
            return order;
        }

        public List<Dish> OrderNight(List<int> itens)
        {
            Menu menu = new Menu();
            List<Dish> order = new List<Dish>();
            foreach(int item in itens)
            {
                switch (item)
                {
                    case 1:
                        if (!order.Contains(menu.ListEntrada()[1]))
                            order.Add(menu.ListEntrada()[1]);
                        else
                            throw new InvalidOperationException("Você não pode selecionar Carne duas vezes no periodo da noite");
                        break;
                    case 2:
                        order.Add(menu.ListAcompanhamentos()[1]);
                        break;
                    case 3:
                        if (!order.Contains(menu.ListBebida()[1]))
                            order.Add(menu.ListBebida()[1]);
                        else
                            throw new InvalidOperationException("Você não pode selecionar Vinho duas vezes no periodo da noite");
                        break;
                    case 4:
                        if (!order.Contains(menu.ListSobremesa()[0]))
                            order.Add(menu.ListSobremesa()[0]);
                        else
                            throw new InvalidOperationException("Você não pode selecionar Bolo duas vezes no periodo da noite");
                        break;
                    default:
                        throw new InvalidOperationException("A opção " + item + " é invalida \n Opções possíveis: " + String.Join(",", PossibleOrderNight().AsEnumerable()));

                }
            };
            return order;
        }

        public List<string> PossibleOrderMorning()
        {
            return new List<string>() { "1 -" + Dish.Ovos, "2 -" + Dish.Torrada, "3 -" + Dish.Cafe };
        }

        public List<string> PossibleOrderNight()
        {
            return new List<string>() { "1 -" + Dish.Carne, "2 -" + Dish.Batata, "3 -" + Dish.Vinho, "4 -" + Dish.Bolo };
        }
    }
}
