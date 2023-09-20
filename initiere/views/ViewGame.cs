using System;
using initiere_teorie.models;
using initiere_teorie.services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.views
{
    public class ViewGame
    {
        private ServiceGame _serviceGame;

        public ViewGame()
        {
            this._serviceGame = new ServiceGame();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa lista de jocuri.");
            Console.WriteLine("Apasati tasta 2 pentru a afisa jocul cel mai ieftin");
            Console.WriteLine("Apasati tasta 3 pentru a afisa jocul cel mai scump.");
            Console.WriteLine("Apasati tasta 4 pentru a afisa jocurile in ordine descrescatoare pretului.");
            Console.WriteLine("Apasati tasta 5 pentru a afisa jocurile in ordine crescatoare pretului.");
            Console.WriteLine("Apasati tasta 6 pentru a afisa jocurile in ordine descrescatoare datei de aparitie.");
            Console.WriteLine("Apasati tasta 7 pentru a afisa jocurile in ordine crescatoare datei de aparitie.");
            Console.WriteLine("Apasati tasta 8 pentru a afisa jocurile din categoria dorita.");
            Console.WriteLine("Apasati tasta 9 pentru a afisa jocurile deja inchiriate/cumparate.");
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
                        this._serviceGame.ShowGamess();
                        break;
                    case 2:
                        Book x = this._serviceGame.cheapestGame();
                        x.GetBookDescription();
                        break;
                    case 3:
                        Book y = this._serviceGame.mostExpensiveGame();
                        y.GetBookDescription();
                        break;
                    case 4:
                        this._serviceGame.SortGamesAscendingByPrice();
                        this._serviceGame.ShowGamess();
                        break;
                    case 5:
                        this._serviceGame.SortGamesDescendingByPrice();
                        this._serviceGame.ShowGamess();
                        break;
                    case 6:
                        this._serviceGame.SortGamesDescendingByDate();
                        this._serviceGame.ShowGamess();
                        break;
                    case 7:
                        this._serviceGame.SortGamesAscendingByDate();
                        this._serviceGame.ShowGamess();
                        break;
                    case 8:
                        Console.WriteLine("Introduceti un tip de carte.");
                        genre = Console.ReadLine();
                        this._serviceGame.ShowGenre(genre);
                        break;
                    case 9:
                        this._serviceGame.isRented();
                        break;
                    default:
                        Console.WriteLine("Consultati ......");
                        break;
                }
            }
        }
    }
}