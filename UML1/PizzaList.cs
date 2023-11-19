using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    public class PizzaList
    {
        private Dictionary<int, Pizza> _pizzaList;


        // Constructer

        public PizzaList()
        {
            _pizzaList = new Dictionary<int, Pizza>();
        }


        // Metoder

        public void AddPizza(Pizza pizza)
        {
            _pizzaList.Add(pizza.Nummer, pizza);
        }

        public Dictionary<int, Pizza> GetAllPizzas()
        {
            return _pizzaList;
        }

        public Pizza RemovePizza(Pizza pizza)
        {
            if (_pizzaList.ContainsValue(pizza))
            {
                foreach (var i in _pizzaList)
                {
                    if (i.Value == pizza)
                    {
                        _pizzaList.Remove(i.Key);
                        return pizza;
                    }
                }
            }

            return null;
        }


        public Pizza GetPizza(int pizzanummer)
        {
            if (_pizzaList.ContainsKey(pizzanummer))
            {
                return _pizzaList[pizzanummer];

            }
            else
            {
                // EXCEPTION
                throw new KeyNotFoundException("pizzanummer findes ikke");



                //return null;
            }
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (var pizza in _pizzaList.Values)
            {
                totalPrice += pizza.Pris;
            }

            return totalPrice;
        }

        public void EditPizza(int pizzanummer, Pizza updatedPizza)
        {
            if (_pizzaList.ContainsKey(pizzanummer))
            {
                // UPDATEING
                _pizzaList[pizzanummer] = updatedPizza;
            }
            else
            {
                Console.WriteLine("unknown nummer");
            }
        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }

    



}
