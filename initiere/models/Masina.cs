using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace initiere_teorie.models
{
    public class Masina
    { 
        //clasa este formata este formata din atribute si nmetode
        private String _marca;
        private String _model;
        private String _culoare;
        private int _nrKilometri;
        private int _anFabricatie;
        private bool _isRulata;

        //constructori
        //-->au acelasi nume ca si clasa
        //-->se apeleaaza automat la instantiere
        //-->se pot supraincarca
        //-->nu au tip returnat


        public Masina()
        {
            Console.WriteLine( "Eu sunt constructorul fara parametrii." );
        }
        public Masina(String marca, String model, String culoare, int nrKilometri, int anFabricatie, bool isRulata)
        {
            this._marca = marca;
            this._model = model;
            this._culoare = culoare;
            this._nrKilometri = nrKilometri;
            this._anFabricatie = anFabricatie;
            this._isRulata = isRulata;           
        }   

       //"vw,passat,red,0,1993,false" 
       public  Masina(String proprietati)
        {

            String[] atribute = proprietati.Split(",");

            this._marca = atribute[0];
            this._model = atribute[1];
            this._culoare = atribute[2];
            this._nrKilometri = Int32.Parse(atribute[3]);
            this._anFabricatie = Int32.Parse(atribute[4]);
            this._isRulata = bool.Parse(atribute[5]);       
        }

        public void GetDescriereMasina()
        {
            Console.WriteLine("Marca: " + this._marca);
            Console.WriteLine("Model: " + this._model);
            Console.WriteLine("Culoare: " + this._culoare);
            Console.WriteLine("Numar kilometri: " + this._nrKilometri + " kilometri" );
            Console.WriteLine("Anul de fabricatie: " + this._anFabricatie);
            Console.WriteLine("Rulata: " + this._isRulata);
        }

        //proprietati get si setari

        public String GetMarca()
        {
            return _marca;
        }
        public void SetMarca( String marca)
        {

           this._marca = marca;
        }
        public String GetCuloare()
        {
            return _culoare;
        }
        public void SetCuloare(String culoare)
        {
            this._culoare = culoare;
        }
        public String GetModel()
        {
            return _model;
        }
        public void SetModel(String model)
        {
            this._model = model;

        }
        public int GetNrKilometri()
        {
            return _nrKilometri;
        }
        public void SetNrKilometri(int nrKilometri)
        {
            this._nrKilometri = nrKilometri;
        }
        public int GetAnFabricatie()
        {
            return _anFabricatie;
        }
        public void SetAnFabricatie(int anFabricatie)
        {
            this._anFabricatie = anFabricatie;
        }
        public bool GetIsRulata()
        {
            return _isRulata;
        }
        public void SetRulata(bool isRulata)
        {
            this._isRulata = isRulata;
        }

    }
}
