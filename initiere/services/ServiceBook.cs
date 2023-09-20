using System;
using initiere_teorie.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.services
{
    public class ServiceBook
    {
        private List<Book> _bookList;

        public ServiceBook()
        {
            Book book1 = new Book("The Hunger Games", "Suzanne Collins", "Fantasy", 35, 2010, true);
            Book book2 = new Book("Harry Potter and the Order of the Phoenix", " J.K. Rowling", "SF", 45, 2016, false);
            Book book3 = new Book("Pride and Prejudice", "Jane Austen", "Classic", 25,2023, false);
            Book book4 = new Book("To Kill a Mockingbird", "Harper Lee", "Historical SF", 33, 2017, true);
            Book book5 = new Book("The Chronicles of Narnia", "C.S. Lewis", "SF", 55, 2008, true);
            Book book6 = new Book("Harry Potter and the Deathly Hallows", "J.K. Rowling", "SF", 40, 2012, false);
            Book book7 = new Book("Life of PI", "Yann Martel", "Adventure", 22, 2011, false);

            _bookList = new List<Book>();

            _bookList.Add(book1);
            _bookList.Add(book2);
            _bookList.Add(book3);
            _bookList.Add(book4);
            _bookList.Add(book5);
            _bookList.Add(book6);
            _bookList.Add(book7);
        }

        public void ShowBooks()
        {
            for(int i =0;i<_bookList.Count;i++)
            {
                _bookList[i].GetBookDescription();
                Console.WriteLine("=============================================================");
                Console.WriteLine();
            }
        }
        public Book cheapestBook()
        {
            int minim = 99999;
            int t = 0;
            for (int i = 0; i < _bookList.Count; i++)
            {


                if (minim > _bookList[i].GetPrice())
                {
                    minim = _bookList[i].GetPrice();
                    t = i;
                }
            }
            return this._bookList[t];
        }
        public Book mostExpensiveBook()
        {
            int max = 0;
            int t = 0;
            for (int i = 0; i < _bookList.Count; i++)
            {


                if (max < _bookList[i].GetPrice())
                {
                    max = _bookList[i].GetPrice();
                    t = i;
                }
            }
            return this._bookList[t];
        }
        public void SortBooksAscendingByPrice()
        {
            for (int i = 0; i < _bookList.Count - 1; i++)
            {
                for (int j = i + 1; j < _bookList.Count; j++)
                {
                    if (_bookList[i].GetPrice() < _bookList[j].GetPrice())
                    {

                        Book aux = _bookList[i];
                        _bookList[i] = _bookList[j];
                        _bookList[j] = aux;
                    }
                }
            }
        }
        public void SortBooksDescendingByPrice()
        {
            for (int i = 0; i < _bookList.Count - 1; i++)
            {
                for (int j = i + 1; j < _bookList.Count; j++)
                {
                    if (_bookList[i].GetPrice() > _bookList[j].GetPrice())
                    {

                        Book aux = _bookList[i];
                        _bookList[i] = _bookList[j];
                        _bookList[j] = aux;
                    }
                }
            }
        }
        public void SortBooksAscendingByDate()
        {
            for (int i = 0; i < _bookList.Count - 1; i++)
            {
                for (int j = i + 1; j < _bookList.Count; j++)
                {
                    if (_bookList[i].GetPublishDate() > _bookList[j].GetPublishDate())
                    {

                        Book aux = _bookList[i];
                        _bookList[i] = _bookList[j];
                        _bookList[j] = aux;
                    }
                }
            }
        }
        public void SortBooksDescendingByDate()
        {
            for (int i = 0; i < _bookList.Count - 1; i++)
            {
                for (int j = i + 1; j < _bookList.Count; j++)
                {
                    if (_bookList[i].GetPublishDate() < _bookList[j].GetPublishDate())
                    {

                        Book aux = _bookList[i];
                        _bookList[i] = _bookList[j];
                        _bookList[j] = aux;
                    }
                }
            }
        }
        public void ShowGenre(String gen)
        {
            for (int i = 0; i < _bookList.Count; i++)
                if (_bookList[i].GetGenre() == gen)
                {
                    _bookList[i].GetBookDescription();
                    Console.WriteLine("================================================");
                }
                    
        }
        public void isBorrowed()
        {
            for(int i = 0; i< _bookList.Count; i++)
            {
                if (_bookList[i].GetIsRented() == true)
                    _bookList[i].GetBookDescription();
            }
        }
    }
}
