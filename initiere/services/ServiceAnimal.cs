using System;
using initiere_teorie.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.services
{
    public class ServiceAnimal
    {
        private List<Animal> _animalList;

        public ServiceAnimal()
        {
            Animal animal1 = new Animal("terestru", "tigru", 2, true);
            Animal animal2 = new Animal("zburator", "vultur", 5, true);
            Animal animal3 = new Animal("acvatic", "rechin", 10, true);
            Animal animal4 = new Animal("terestru", "iepure", 2, false);
            Animal animal5 = new Animal("terestru", "gaina", 1, false);
            Animal animal6 = new Animal("zburator", "papagal", 1, false);
            Animal animal7 = new Animal("terestru", "leu", 7, true);

            _animalList = new List<Animal>();

            _animalList.Add(animal1);
            _animalList.Add(animal2);
            _animalList.Add(animal3);
            _animalList.Add(animal4);
            _animalList.Add(animal5);
            _animalList.Add(animal6);
            _animalList.Add(animal7);
        }
    }
    //public void ShowAnimal()
    //{
    //    for (int i = 0; i < _animalList.Count; i++) ;
    //}
}
   
