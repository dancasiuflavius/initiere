using System;
using initiere_teorie.models;
using initiere_teorie.services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.views
{
    public class ViewFood
    {
        private ServiceFood _serviceFood;

        public ViewFood()
        {

            this._serviceFood = new ServiceFood();
        }
        public void Meniu()
        {

            Console.WriteLine("Apasati tasta 1 pentru a afisa meniul disponibil");
            Console.WriteLine("Apasati tasta 2 pentru a afisa preturile crescator");
            Console.WriteLine("Apasati tasta 3 pentru a afisa preturile descrescator");

            Console.WriteLine("MENIU ADMINISTRATOR");
            Console.WriteLine("Apasati tasta 4 pentru a adauga un produs nou.");
            Console.WriteLine("Apasati tasta 5 pentru a sterge un produs din lista.");
            Console.WriteLine("Apasati tasta 6 pentru a modifica un produs deja existent.");

        }
        public void Play()
        {
            bool running = true;
            int alegere = 0;
            int position = -1;

            String categorie = "categorie";
            String nume = "nume";
            String ingrediente = "ingrediente";
            int pret = 0;
            bool isVegan = false;

            while (running)
            {
                Meniu();

                alegere = Int32.Parse(Console.ReadLine());


                switch (alegere)
                {
                    case 1:
                        this._serviceFood.ShowFood();
                        break;
                    case 2:
                        this._serviceFood.SortFoodAscendingByPrice();
                        break;
                    case 3:
                        this._serviceFood.SortFoodDescendingByPrice();
                        break;
                    case 4:
                        Console.WriteLine("Introduceti pozitia produsului pe care doriti sa il eliminati. ");
                        position = Int32.Parse(Console.ReadLine());
                        this._serviceFood.RemoveFood(position);
                        break;
                    
                    case 5:
                        Console.WriteLine("Introduceti numele categoriei produsului nou.");
                        categorie = Console.ReadLine();
                        Console.WriteLine("Introduceti numele noului produsului.");
                        nume = Console.ReadLine();
                        Console.WriteLine("Introduceti ingredientele noului produsului. Folositi ',' in enumeratia ingredientelor.");
                        ingrediente = Console.ReadLine();
                        Console.WriteLine("Introduceti pretul noului produs.");
                        pret = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Vegan/Nu");
                        isVegan = bool.Parse(Console.ReadLine());
                        this._serviceFood.AddNewFood(categorie, nume, ingrediente, pret, isVegan);
                        break;
                    case 6:
                        Console.WriteLine("Introduceti pozitia produsului pe care doriti sa il modificati");
                        position = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduceti categoria produsului din care face parte.");
                        categorie = Console.ReadLine();
                        Console.WriteLine("Introduceti numele produsului.");
                        nume = Console.ReadLine();
                        Console.WriteLine("Introduceti ingredientele produsului. Folositi ',' in enumeratia ingredientelor.");
                        ingrediente = Console.ReadLine();
                        Console.WriteLine("Introduceti pretul produsului.");
                        pret = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Vegan/Nu");
                        isVegan = bool.Parse(Console.ReadLine());
                        this._serviceFood.UpdateFood(position, categorie, nume, ingrediente, pret, isVegan);
                        break;


                    default:
                        Console.WriteLine("Operatiune invalida.");
                        break;

                }
            }
        }
    }
}
        
        
