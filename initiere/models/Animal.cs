using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.models
{
    public class Animal
    {
        private String _category;
        private String _name;
        private int _age;
        private bool _isDangerous;

        public Animal()
        {


        }
        public Animal(string category, string name, int age, bool isDangerous)
        {
            this._category = category;
            this._name = name;
            this._age = age;
            this._isDangerous = isDangerous;
        }
        public Animal(String proprietati)
        {
            String[] atribute = proprietati.Split(',');
            this._category = atribute[0];
            this._name = atribute[1];
            this._age = Int32.Parse(atribute[2]);
            this._isDangerous = bool.Parse(atribute[3]);
        }
        public void GetAnimalDescription()
        {
            Console.WriteLine("Categorie: " + this._category);
            Console.WriteLine("Denumire: " + this._name);
            Console.WriteLine("Varsta: " + this._age);
            Console.WriteLine("Periculos: " + this._isDangerous);
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
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            this._age = age;
        }
        public bool GetIsDangerous()
        {
            return _isDangerous;
        }
        public void SetIsDangerous(bool isDangerous)
        {
            this._isDangerous = isDangerous;
        }
    }
}
