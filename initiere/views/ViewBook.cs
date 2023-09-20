using System;
using initiere_teorie.models;
using initiere_teorie.services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.views
{
    public class ViewBook
    {
        private ServiceBook _serviceBook;

        public ViewBook()
        {
            this._serviceBook = new ServiceBook();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa lista de carti.");
            Console.WriteLine("Apasati tasta 2 pentru a afisa cartea cea mai ieftina.");
            Console.WriteLine("Apasati tasta 3 pentru a afisa cartea cea mai scumpa.");
            Console.WriteLine("Apasati tasta 4 pentru a afisa cartile in ordine descrescatoare pretului.");
            Console.WriteLine("Apasati tasta 5 pentru a afisa cartile in ordine crescatoare pretului.");
            Console.WriteLine("Apasati tasta 6 pentru a afisa cartile in ordine descrescatoare datei de aparitie.");
            Console.WriteLine("Apasati tasta 7 pentru a afisa cartile in ordine crescatoare datei de aparitie.");
            Console.WriteLine("Apasati tasta 8 pentru a afisa cartile din categoria dorita.");
            Console.WriteLine("Apasati tasta 9 pentru a afisa cartile deja inchiriate/cumparate.");
        }
        public void Play()
        {

            bool running = true;
            String genre = "Adventure";

            int alegere = 0;

            while (running)
            {
                Meniu();

                alegere = Int32.Parse(Console.ReadLine());
                

                switch (alegere)
                {
                    case 1:
                        this._serviceBook.ShowBooks();
                        break;
                    case 2:
                        Book x = this._serviceBook.cheapestBook();
                        x.GetBookDescription();
                        break;
                    case 3:
                        Book y = this._serviceBook.mostExpensiveBook();
                        y.GetBookDescription();
                        break;
                    case 4:
                        this._serviceBook.SortBooksAscendingByPrice();
                        this._serviceBook.ShowBooks();
                        break;
                    case 5:
                        this._serviceBook.SortBooksDescendingByPrice();
                        this._serviceBook.ShowBooks();
                        break;
                    case 6:
                        this._serviceBook.SortBooksDescendingByDate();
                        this._serviceBook.ShowBooks();
                        break;
                    case 7:
                        this._serviceBook.SortBooksAscendingByDate();
                        this._serviceBook.ShowBooks();
                        break;
                    case 8:
                        Console.WriteLine("Introduceti un tip de carte.");
                        genre = Console.ReadLine();
                        this._serviceBook.ShowGenre(genre);
                        break;
                    case 9:
                        this._serviceBook.isBorrowed();
                        break;
                    default:
                        Console.WriteLine("Consultati ......");
                        break;
                }
            }
        }
    }
}
