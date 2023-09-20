using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.models
{
    public class Student
    {
        private String _surname;
        private String _name;
        private int _age;
        private int _grade;
        private String _profile;
        private bool _hasPassed;

        public Student()
        {

        }
        public Student(string surname, string name, int age, int grade, String profile, bool hasPassed)
        {
            this._surname = surname;
            this._name = name;
            this._age = age;
            this._grade = grade;
            this._profile = profile;
            this._hasPassed = hasPassed;
        }
        public Student(String proprietati)
        {
            String[] atribute = proprietati.Split(",");

            this._surname = atribute[0];
            this._name = atribute[1];
            this._age = Int32.Parse(atribute[2]);
            this._grade = Int32.Parse(atribute[3]);
            this._profile = atribute[4];
            this._hasPassed = bool.Parse(atribute[5]);
        }

        public void GetStudentDescription()
        {
            Console.WriteLine("Nume: " + this._surname);
            Console.WriteLine("Prenume: " + this._name);
            Console.WriteLine("Varsta: " + this._age);
            Console.WriteLine("Clasa: " + this._grade);
            Console.WriteLine("Profilul: " + this._profile);
            Console.WriteLine("Promovat/Nepromovat: " + this._hasPassed);
        }

        // Get & Set

        public String GetSurame()
        {
            return _surname;
        }
        public void SetSurname( String surname)
        {
            this._surname = surname;
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
        public int GetGrade()
        {
            return _grade;
        }
        public void SetGrade(int grade)
        {
            this._grade = grade;
        }
        public String GetProfile()
        {
            return _profile;
        }
        public void SetProfile(String profile)
        {
            this._profile = profile;
        }
        public bool GetHasPassed()
        {
            return _hasPassed;
        }
        public void SetHasPassed(bool hasPassed)
        {
            this._hasPassed = hasPassed;
        }




    }
}
