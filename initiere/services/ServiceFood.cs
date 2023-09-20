using System;
using initiere_teorie.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.services
{
    public class ServiceFood
    {
        private List<Food> _foodList;
        public Food newFood= new Food();


        public ServiceFood()
        {
            Food food1 = new Food("Burger","Burger Vita Angus", "Chifla Homemade, Castraveti Murati, Branza Cheddar, Carne Vita, Salata Iceberg", 10, false);
            Food food2 = new Food("Burger","Burget Spicey", "Chifla Homemade, Castraveti Murati, Branza Cheddar, Carne Vita, Extra Spicey Sauce, Salata Iceberg, Rosii", 11, false);
            Food food3 = new Food("Burger", "Vegan's Favourite", "Chifla Homemade, Tofu la gratar, Soia, Salata, Rosii, Castraveti, Sos la alegere",15, true);
            Food food4 = new Food("Pizza", "Pizza Pepperoni", "Blat italian, mozzarela, pepperoni, ardei spicey", 22, false);
            Food food5 = new Food("Pizza", "Cheese Pizza", "Blat pufos, mozzarela, cheddar, cascaval, blue cheese, parmezan", 20, true);
            Food food6 = new Food("Pizza", "Vegan Pizza", "Blat normal, porumb, rosii, ardei, mozzarela, sos pizza", 18, true);
            Food food7 = new Food("Pizza", "Fresh", "Blat Philadelphia, Piept de pui, Porumb, Rosii, Spanac", 25, false);

            _foodList = new List<Food>();

            _foodList.Add(food1);
            _foodList.Add(food2);
            _foodList.Add(food3);
            _foodList.Add(food4);
            _foodList.Add(food5);
            _foodList.Add(food6);
            _foodList.Add(food7);
        }
        public void ShowFood()
        {
            for (int i = 0; i < _foodList.Count; i++)
            {

                _foodList[i].GetFoodDescription();
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            }
        }
        public void SortFoodAscendingByPrice()
        {
            for (int i = 0; i < _foodList.Count - 1; i++)
            {
                for (int j = i + 1; j < _foodList.Count; j++)
                {
                    if (_foodList[i].GetPrice() > _foodList[j].GetPrice())
                    {

                        Food aux = _foodList[i];
                        _foodList[i] = _foodList[j];
                        _foodList[j] = aux;
                    }
                }
            }
            for(int i = 0; i<_foodList.Count; i++)
            {
                _foodList[i].GetFoodDescription();
            }
        }
        public void SortFoodDescendingByPrice()
        {
            for (int i = 0; i < _foodList.Count - 1; i++)
            {
                for (int j = i + 1; j < _foodList.Count; j++)
                {
                    if (_foodList[i].GetPrice() < _foodList[j].GetPrice())
                    {

                        Food aux = _foodList[i];
                        _foodList[i] = _foodList[j];
                        _foodList[j] = aux;
                    }
                }
            }
            for (int i = 0; i < _foodList.Count; i++)
            {
                _foodList[i].GetFoodDescription();
            }
        }
        public void RemoveFood(int pozitie)
        {
            for (int i = 0; i <= _foodList.Count; i++)
            {
                if (pozitie == i)
                    _foodList.RemoveAt(i);
            }
        }
        public void AddNewFood(String category, String name, String ingredients, int price, bool isVegan)
        {
            newFood.SetCategory(category);
            newFood.SetName(name);
            newFood.SetIngredients(ingredients);
            newFood.SetPrice(price);
            newFood.SetIsVegan(isVegan);
   
            _foodList.Add(newFood);
        }
        public void UpdateFood(int pozitie, String categorie,String nume, String ingrediente,int pret, bool isVegan)
        {
            for (int i = 0; i < _foodList.Count; i++)
            {
                if (pozitie == i)
                {

                    _foodList[i].SetCategory(categorie);
                    _foodList[i].SetName(nume);
                    _foodList[i].SetIngredients(ingrediente);
                    _foodList[i].SetPrice(pret);
                    _foodList[i].SetIsVegan(isVegan);


                }
            }
        }
        //public void UpdateFoodByProductSearch(String name1, String categorie, String nume, String ingrediente, int pret, bool isVegan)
        //{
        //    int pozitie = 0;
        //    for (int i = 0; i < _foodList.Count; i++)
        //    {
                
        //        if (_foodList[i].GetName() == name1)
        //        {

        //            _foodList[i].SetCategory(categorie);
        //            _foodList[i].SetName(nume);
        //            _foodList[i].SetIngredients(ingrediente);
        //            _foodList[i].SetPrice(pret);
        //            _foodList[i].SetIsVegan(isVegan);


        //        }
        //        pozitie++;
        //    }
        //}
    }
}
