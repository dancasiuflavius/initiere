using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.models
{
    public class Food
    {
        private String _category;
        private String _name;
        private String _ingredients;
        private int _price;
        private bool _isVegan;

        public Food()
        {

        }
        public Food(String category, String name, String ingredients, int price, bool isVegan)
        {
            this._category = category;
            this._name = name;
            this._ingredients = ingredients;
            this._price = price;
            this._isVegan = isVegan;
        }

        public Food(String proprietati)
        {
            String[] atribute = proprietati.Split(",");
            this._category = atribute[0];
            this._ingredients = atribute[1];
            this._price = Int32.Parse(atribute[2]);
            this._isVegan = bool.Parse(atribute[3]);
        }

        public void GetFoodDescription()
        {
            Console.WriteLine("Categoria produsului: " + this._category);
            Console.WriteLine("Numele produsului: " + this._name);
            Console.WriteLine("Ingredientele produsului: " + this._ingredients);
            Console.WriteLine("Pret:" + this._price + "$");
            Console.WriteLine("Produs vegan: " + this._isVegan);
        }

        public String GetCategory()
        {
            return _category;
        }
        public void SetCategory(String category)
        {
            this._category = category;
        }
        public String GetName()
        {
            return _name;
        }
        public void SetName(String name)
        {
            this._name = name;
        }
        public String GetIngredients()
        {
            return _ingredients;
        }
        public void SetIngredients(String ingredients)
        {
            this._ingredients = ingredients;
        }
        public int GetPrice()
        {
            return this._price;
        }
        public void SetPrice(int price)
        {
            this._price = price;
        }
        public bool GetIsVegan()
        {
            return this._isVegan;
        }
        public void SetIsVegan(bool isVegan)
        {
            this._isVegan = isVegan;
        }
    }
}
