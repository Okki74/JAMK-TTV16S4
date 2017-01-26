using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Fridge
    {
        private double temperature;
        public List<Vegetable> Veges { get; set; }
        public List<Food> Foods { get; set; }
        public List<Drink> Drinks { get; set; }

        public double Temperature
        {
         get { return temperature; }
         set { temperature = value; }      
        }
        // Construktor
        public Fridge() { }
        public Fridge(double _temp,Vegetable _veges,Food _food, Drink _drinks, int _pcsDrinks) {
            temperature = _temp;
            Veges = new List<Vegetable>();
            AddVeges(_veges);
            Foods = new List<Food>();
            AddFood(_food);
            Drinks = new List<Drink>();
            for (int i=0; i < _pcsDrinks; i++)
            {
                AddDrink(_drinks);
            }

        }
        //Methods
        public void AddVeges(Vegetable t)
        {
            Veges.Add(t);
        }
        public void AddDrink(Drink t)
        {
            Drinks.Add(t);
        }
        public void AddFood(Food t)
        {
            Foods.Add(t);
        }
        public override string ToString()
        {
            string str = "Temperature: " + Temperature+ "\n";
            foreach (Vegetable t in Veges)
            {
                str += "\n";
                str += t.ToString();
            }
            foreach (Food t in Foods)
            {
                str += "\n";
                str += t.ToString();
            }
            foreach (Drink t in Drinks)
            {
                str += "\n";
                str += t.ToString();
            }
            return str;
        }
    }


}
