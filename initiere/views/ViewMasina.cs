using initiere_teorie.models;
using initiere_teorie.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.views
{
    public class ViewMasina
    {

        private ServiceMasina _serviceMasina;

        public ViewMasina()
        {

            this._serviceMasina = new ServiceMasina();
        }

        public void Meniu()
        {

            Console.WriteLine("Apasati tasta 1 pentru a afisa masinile disponibile");
            Console.WriteLine("Apasati tasta 2 pentru a afisa masina cu cei mai MULTI kilometri (cea mai folosita)" );
            Console.WriteLine("Apasati tasta 3 pentru a afisa masina cu cei mai PUTINI kilometri (cea mai folosita)");
            Console.WriteLine("Apasati tasta 4 pentru a afisa masina cea mai NOUA");
            Console.WriteLine("Apasati tasta 5 pentru a afisa masina cea mai VECHE");
            Console.WriteLine("Apasati tasta 6 pentru a afisa masinile in ordine crescatoare a numarului de kilometrii");
            Console.WriteLine("Apasati tasta 7 pentru a afisa masinile in ordine descrescatoare a numarului de kilometrii");

            Console.WriteLine("Apasati tasta 8 pentru a afisa masinile in ordine crescatoare a anului de aparitie");
            Console.WriteLine("Apasati tasta 9 pentru a afisa masinile in ordine descrescatoare a anului de aparitie");

            Console.WriteLine("Apasati tasta 10 pentru a afisa masinile rulate");


            Console.WriteLine("~~~~~~ADD, REMOVE, UPDATE MENU~~~~~~~~");

            Console.WriteLine("Apasati tasta 11 pentru a sterge o masina din lista, apoi alegeti numarul masinii.");
            Console.WriteLine("Apasati tasta 12 pentru a adauga o masina in lista.");
            Console.WriteLine("Apasati tasta 13 pentru a modifica o masina din lista.");
        }
        


        public void Play()
        {

            bool running = true;

            int alegere = 0;

            int position = -1;

            String model = "model";
            String marca = "marca";
            String culoare = "culoare";
            int nrKilometri;
            int anFabricatie = 0;
            bool isRulata = false;

            


            while (running)
            {
                Meniu();

                alegere = Int32.Parse(Console.ReadLine());
                

                switch (alegere)
                {
                    case 1:
                        this._serviceMasina.ShowCars();
                        break;

                    case 2:
                        Masina x=this._serviceMasina.mostUsed();
                        x.GetDescriereMasina();
                        break;
                    case 3:
                        Masina z = this._serviceMasina.lowestUsed();
                        z.GetDescriereMasina();
                        break;
                    case 4:
                        Masina a = this._serviceMasina.newestCar();
                        a.GetDescriereMasina();
                        break;
                    case 5:
                        Masina b = this._serviceMasina.oldestCar();
                        b.GetDescriereMasina();
                        break;
                    case 6:
                        this._serviceMasina.SortCarsAscendingByKm();
                        this._serviceMasina.ShowCars();
                        break;
                    case 7:
                        this._serviceMasina.SortCarsDescendingByKm();
                        this._serviceMasina.ShowCars();
                        break;
                    case 8:
                        this._serviceMasina.SortCarsAscendingByDate();
                        this._serviceMasina.ShowCars();
                        break;
                    case 9:
                        this._serviceMasina.SortCarsDescendingByDate();
                        this._serviceMasina.ShowCars();
                        break;
                    case 10:
                        this._serviceMasina.ShowUnusedCars();
                        break;
                    case 11:
                       
                        Console.WriteLine("Introduceti numarul masinii pe care doriti sa o eliminati.");
                        position = Int32.Parse(Console.ReadLine());
                        this._serviceMasina.RemoveCar(position);
                        this._serviceMasina.ShowCars();
                        break;
                    case 12:
                        Console.WriteLine("Introduceti marca masinii.");
                        marca = Console.ReadLine();
                        Console.WriteLine("Introduceti modelul masinii.");
                        model = Console.ReadLine();
                        Console.WriteLine("Introduceti culoarea masinii.");
                        culoare = Console.ReadLine();
                        Console.WriteLine("Introduceti kilometri masinii.");
                        nrKilometri = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduceti anul masinii.");
                        anFabricatie = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduceti daca masina a fost rulata sau nu. (true/false)");
                        isRulata = bool.Parse(Console.ReadLine());
                        this._serviceMasina.AddNewCar(marca, model, culoare, nrKilometri, anFabricatie, isRulata);
                        this._serviceMasina.ShowCars();

                        break;
                    case 13:
                        Console.WriteLine("Introduceti numarul masinii pe care doriti sa o modificati.");
                        position = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduceti culoarea masinii.");
                        culoare = Console.ReadLine();
                        Console.WriteLine("Introduceti kilometri masinii.");
                        nrKilometri = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduceti anul masinii.");
                        anFabricatie = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduceti daca masina a fost rulata sau nu. (true/false)");
                        isRulata = bool.Parse(Console.ReadLine());
                        this._serviceMasina.UpdateCar(position, culoare, nrKilometri, anFabricatie, isRulata);
                        this._serviceMasina.ShowCars();
                        break;

                    default:
                        Console.WriteLine("Consultati ......");
                        break;
                }
            }
        }
    }
}
