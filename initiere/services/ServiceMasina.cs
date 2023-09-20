using initiere_teorie.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.services
{
    public class ServiceMasina
    {
        private List<Masina> _masinaList;

        public Masina newCar = new Masina();

        public ServiceMasina()
        {
            Masina masina1 = new Masina("VW", "Passat", "Red", 50000, 2010, true);
            Masina masina2 = new Masina("Ford", "Fiesta", "Silver", 25000, 2015, true);
            Masina masina3 = new Masina("Toyota", "Camry", "Black", 8000, 2022, false);
            Masina masina4 = new Masina("Honda", "Civic", "White", 35000, 2019, true);
            Masina masina5 = new Masina("Chevrolet", "Malibu", "Gray", 45000, 2018, false);
            Masina masina6 = new Masina("Hyundai", "Elantra", "Red", 30000, 2021, true);
            Masina masina7 = new Masina("Nissan", "Altima", "Green", 15000, 2020, true);
            Masina masina8 = new Masina("Kia", "Optima", "Blue", 6000, 2023, false);
            Masina masina9 = new("BMW", "X5", "Black", 7000, 2023, true);
            Masina masina10 = new Masina("Mercedes-Benz", "C-Class", "Silver", 9000, 2023, false);

            Masina masinaX = new Masina("Tesla", "Model X", "White", 0, 2023, false);
            Masina masinaY = new Masina("Nissan", "GTR", "Red & White", 55000, 2015, true);
            Masina masinaZ = new Masina("Porsche", "Panamera", "Yellow", 18200, 2018, true);

            _masinaList = new List<Masina>();

            _masinaList.Add(masina1);
            _masinaList.Add(masina2);
            _masinaList.Add(masina3);
            _masinaList.Add(masina4);
            _masinaList.Add(masina5);
            _masinaList.Add(masina6);
            _masinaList.Add(masina7);
            _masinaList.Add(masina8);
            _masinaList.Add(masina9);
            _masinaList.Add(masina10);
            _masinaList.Add(masinaX);
            _masinaList.Add(masinaY);
            _masinaList.Add(masinaZ);
        }

        public void ShowCars()
        {
            for (int i = 0; i < _masinaList.Count; i++)
            {

                _masinaList[i].GetDescriereMasina();
                Console.WriteLine("=============================================================");
            }
        }
        public Masina mostUsed()
        {
            int max = _masinaList[0].GetNrKilometri();
            int t = 0;
            for (int i = 0; i < _masinaList.Count; i++)
            {


                if (max < _masinaList[i].GetNrKilometri())
                {
                    max = _masinaList[i].GetNrKilometri();
                    t = i;

                }

            }
            return this._masinaList[t];
        }
        public Masina lowestUsed()
        {
            int max = _masinaList[0].GetNrKilometri();
            int t = 0;
            for (int i = 0; i < _masinaList.Count; i++)
            {


                if (max > _masinaList[i].GetNrKilometri())
                {
                    max = _masinaList[i].GetNrKilometri();
                    t = i;

                }

            }
            return this._masinaList[t];
        }
        public Masina newestCar()
        {
            int max = _masinaList[0].GetAnFabricatie();
            int t = 0;
            for (int i = 0; i < _masinaList.Count; i++)
            {
                if (max < _masinaList[i].GetAnFabricatie())
                {
                    max = _masinaList[i].GetAnFabricatie();
                    t = i;
                }
            }
            return this._masinaList[t];
        }
        public Masina oldestCar()
        {
            int max = _masinaList[0].GetAnFabricatie();
            int t = 0;
            for (int i = 0; i < _masinaList.Count; i++)
            {
                if (max > _masinaList[i].GetAnFabricatie())
                {
                    max = _masinaList[i].GetAnFabricatie();
                    t = i;
                }
            }
            return this._masinaList[t];
        }
        public void SortCarsAscendingByKm()
        {
            for (int i = 0; i < _masinaList.Count - 1; i++)
            {
                for (int j = i + 1; j < _masinaList.Count; j++)
                {
                    if (_masinaList[i].GetNrKilometri() > _masinaList[j].GetNrKilometri())
                    {

                        Masina aux = _masinaList[i];
                        _masinaList[i] = _masinaList[j];
                        _masinaList[j] = aux;
                    }
                }
            }
        }
        public void SortCarsDescendingByKm()
        {
            for (int i = 0; i < _masinaList.Count - 1; i++)
            {
                for (int j = i + 1; j < _masinaList.Count; j++)
                {
                    if (_masinaList[i].GetNrKilometri() < _masinaList[j].GetNrKilometri())
                    {

                        Masina aux = _masinaList[i];
                        _masinaList[i] = _masinaList[j];
                        _masinaList[j] = aux;
                    }
                }
            }
        }
        public void SortCarsAscendingByDate()
        {
            for (int i = 0; i < _masinaList.Count - 1; i++)
            {
                for (int j = i + 1; j < _masinaList.Count; j++)
                {
                    if (_masinaList[i].GetAnFabricatie() > _masinaList[j].GetAnFabricatie())
                    {

                        Masina aux = _masinaList[i];
                        _masinaList[i] = _masinaList[j];
                        _masinaList[j] = aux;
                    }
                }
            }
        }
        public void SortCarsDescendingByDate()
        {
                for (int i = 0; i < _masinaList.Count - 1; i++)
                {
                    for (int j = i + 1; j < _masinaList.Count; j++)
                    {
                        if (_masinaList[i].GetAnFabricatie() < _masinaList[j].GetAnFabricatie())
                        {

                            Masina aux = _masinaList[i];
                            _masinaList[i] = _masinaList[j];
                            _masinaList[j] = aux;
                        }
                    }
                }

        }
        public void ShowUnusedCars()
        {
            
            for(int i=0; i < _masinaList.Count; i++)
            {
                if (_masinaList[i].GetIsRulata() == true)
                {
                    _masinaList[i].GetDescriereMasina();
                }
                                        
            }           
        }
        public void RemoveCar(int pozitie)
        {
            for(int i=0; i<=_masinaList.Count;i++)
            {
                if (pozitie == i)
                    _masinaList.RemoveAt(i);
            }
        }
        public void AddNewCar(String marca, String model, String culoare, int nrKilometri, int anFabricatie, bool isRulata)
        {
            newCar.SetMarca(marca);
            newCar.SetModel(model);
            newCar.SetCuloare(culoare);
            newCar.SetNrKilometri(nrKilometri);
            newCar.SetAnFabricatie(anFabricatie);
            newCar.SetRulata(isRulata);
            _masinaList.Add(newCar);
        }
        public void UpdateCar(int pozitie, String culoare, int nrKilometri, int anFabricatie, bool isRulata)
        {
            for(int i = 0;i < _masinaList.Count;i++)
            {
                if(pozitie==i)
                {
                    
                    _masinaList[i].SetCuloare(culoare);
                    _masinaList[i].SetNrKilometri(nrKilometri);
                    _masinaList[i].SetAnFabricatie(anFabricatie);
                    _masinaList[i].SetRulata(isRulata);


                }
            }
        }

    }
}
