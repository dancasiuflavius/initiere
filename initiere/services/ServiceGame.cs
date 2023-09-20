using System;
using initiere_teorie.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.services
{
    public class ServiceGame
    {
        private List<Book> _gameList;

        public ServiceGame()
        {
            Book book1 = new Book("The Hunger Games", "Suzanne Collins", "Fantasy", 35, 2010, true);
            Book book2 = new Book("Harry Potter and the Order of the Phoenix", " J.K. Rowling", "SF", 45, 2016, false);
            Book book3 = new Book("Pride and Prejudice", "Jane Austen", "Classic", 25, 2023, false);
            Book book4 = new Book("To Kill a Mockingbird", "Harper Lee", "Historical SF", 33, 2017, true);
            Book book5 = new Book("The Chronicles of Narnia", "C.S. Lewis", "SF", 55, 2008, true);
            Book book6 = new Book("Harry Potter and the Deathly Hallows", "J.K. Rowling", "SF", 40, 2012, false);
            Book book7 = new Book("Life of PI", "Yann Martel", "Adventure", 22, 2011, false);

            _gameList = new List<Book>();

            _gameList.Add(book1);
            _gameList.Add(book2);
            _gameList.Add(book3);
            _gameList.Add(book4);
            _gameList.Add(book5);
            _gameList.Add(book6);
            _gameList.Add(book7);
        }

        public void ShowGamess()
        {
            for (int i = 0; i < _gameList.Count; i++)
            {
                _gameList[i].GetBookDescription();
                Console.WriteLine("=============================================================");
                Console.WriteLine();
            }
        }
        public Book cheapestGame()
        {
            int minim = 99999;
            int t = 0;
            for (int i = 0; i < _gameList.Count; i++)
            {


                if (minim > _gameList[i].GetPrice())
                {
                    minim = _gameList[i].GetPrice();
                    t = i;
                }
            }
            return this._gameList[t];
        }
        public Book mostExpensiveGame()
        {
            int max = 0;
            int t = 0;
            for (int i = 0; i < _gameList.Count; i++)
            {


                if (max < _gameList[i].GetPrice())
                {
                    max = _gameList[i].GetPrice();
                    t = i;
                }
            }
            return this._gameList[t];
        }
        public void SortGamesAscendingByPrice()
        {
            for (int i = 0; i < _gameList.Count - 1; i++)
            {
                for (int j = i + 1; j < _gameList.Count; j++)
                {
                    if (_gameList[i].GetPrice() < _gameList[j].GetPrice())
                    {

                        Book aux = _gameList[i];
                        _gameList[i] = _gameList[j];
                        _gameList[j] = aux;
                    }
                }
            }
        }
        public void SortGamesDescendingByPrice()
        {
            for (int i = 0; i < _gameList.Count - 1; i++)
            {
                for (int j = i + 1; j < _gameList.Count; j++)
                {
                    if (_gameList[i].GetPrice() > _gameList[j].GetPrice())
                    {

                        Book aux = _gameList[i];
                        _gameList[i] = _gameList[j];
                        _gameList[j] = aux;
                    }
                }
            }
        }
        public void SortGamesAscendingByDate()
        {
            for (int i = 0; i < _gameList.Count - 1; i++)
            {
                for (int j = i + 1; j < _gameList.Count; j++)
                {
                    if (_gameList[i].GetPublishDate() > _gameList[j].GetPublishDate())
                    {

                        Book aux = _gameList[i];
                        _gameList[i] = _gameList[j];
                        _gameList[j] = aux;
                    }
                }
            }
        }
        public void SortGamesDescendingByDate()
        {
            for (int i = 0; i < _gameList.Count - 1; i++)
            {
                for (int j = i + 1; j < _gameList.Count; j++)
                {
                    if (_gameList[i].GetPublishDate() < _gameList[j].GetPublishDate())
                    {

                        Book aux = _gameList[i];
                        _gameList[i] = _gameList[j];
                        _gameList[j] = aux;
                    }
                }
            }
        }
        public void ShowGenre(String gen)
        {
            for (int i = 0; i < _gameList.Count; i++)
                if (_gameList[i].GetGenre() == gen)
                {
                    _gameList[i].GetBookDescription();
                    Console.WriteLine("================================================");
                }

        }
        public void isRented()
        {
            for (int i = 0; i < _gameList.Count; i++)
            {
                if (_gameList[i].GetIsRented() == true)
                    _gameList[i].GetBookDescription();
            }
        }
    }
}
