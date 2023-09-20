using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.models
{
    internal class Game
    {
        private String _name;
        private String _author;
        private String _genre;
        private int _price;
        private int _publishDate;
        private bool _isRented;


        //Constructori
        public Game()
        {
            Console.WriteLine("Constructorul carte fara parametrii.");
        }
        public Game(string name, string author, string genre, int price, int publishDate, bool isRented)
        {
            this._name = name;
            this._author = author;
            this._genre = genre;
            this._price = price;
            this._publishDate = publishDate;
            this._isRented = isRented;


        }
        public Game(String proprietati)
        {
            String[] atribute = proprietati.Split(",");
            this._name = atribute[0];
            this._author = atribute[1];
            this._genre = atribute[2];
            this._price = Int32.Parse(atribute[3]);
            this._publishDate = Int32.Parse(atribute[4]);
            this._isRented = bool.Parse(atribute[5]);
        }
        public void GetGameDescription()
        {
            Console.WriteLine("Denumire joc: " + this._name);
            Console.WriteLine("Numele producatorului: " + this._author);
            Console.WriteLine("Genul jocului: " + this._genre);
            Console.WriteLine("Pretul jocului: " + this._price + "$");
            Console.WriteLine("Data aparitiei: " + this._publishDate);
            Console.WriteLine("Cumparat: " + this._isRented);
            Console.WriteLine("==========================================");
        }
        //Get & Set
        public String GetName()
        {
            return _name;
        }
        public void SetName(String name)
        {
            this._name = name;
        }
        public String GetAuthor()
        {
            return _author;
        }
        public void SetAuthor(String author)
        {
            this._author = author;
        }
        public String GetGenre()
        {
            return _genre;

        }
        public void SetGenre(String genre)
        {
            this._genre = genre;
        }
        public int GetPrice()
        {
            return _price;
        }
        public void SetPrice(int price)
        {
            this._price = price;
        }
        public int GetPublishDate()
        {
            return _publishDate;
        }
        public void SetPublishDate(int publishDate)
        {
            this._publishDate = publishDate;
        }
        public bool GetIsRented()
        {
            return _isRented;
        }
        public void SetIsRented(bool isRented)
        {
            this._isRented = isRented;
        }
    }
}
