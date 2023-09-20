using initiere_teorie.models;
using initiere_teorie.services;

namespace initiere_teorie.views
{
    public class ViewStudent
    {
        private ServiceStudent _serviceStudent;

        public ViewStudent()
        {

            this._serviceStudent = new ServiceStudent();
        }
        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa studentii.");
            Console.WriteLine("Apasati tasta 2 pentru a afisa studentii in ordine alfabetica.");
            Console.WriteLine("Apasati tasta 3 pentru a afisa toti elevii care NU au trecut.");
            Console.WriteLine("Apasati tasta 4 pentru a afosa toti elevii care AU trecut.");
            Console.WriteLine("Apasati tasta 5 pentru a afisa elevii in ordine crescatoare varstei.");
            Console.WriteLine("Apasati tasta 6 pentru a afisa elevii in ordine descrescatoare varstei.");
            Console.WriteLine("Apasati tasta 7 pentru a afisa toti elevii dintr-un anumit profil");

        }
        public void Play()
        {

            bool running = true;

            int alegere = 0;

            String profile = "NULL";

            while (running)
            {
                Meniu();

                alegere = Int32.Parse(Console.ReadLine());

                switch (alegere)
                {
                    case 1:
                        this._serviceStudent.ShowStudents();
                        break;
                     
                    case 2:
                        this._serviceStudent.alphabeticalSort();
                        this._serviceStudent.ShowStudents();
                        break;
                    case 3:
                        this._serviceStudent.ShowFailedStudents();
                        break;
                    case 4:
                        this._serviceStudent.ShowPassedStudents();
                        break;
                    case 5:
                        this._serviceStudent.SortStudentsAscendingByAge();
                        this._serviceStudent.ShowStudents();
                        break;
                    case 6:
                        this._serviceStudent.SortStudentsDescendingByAge();
                        this._serviceStudent.ShowStudents();
                        break;
                    case 7:
                        Console.WriteLine("Introduceti un profil.");
                        profile = Console.ReadLine();
                        this._serviceStudent.ShowProfile(profile);
                        break;
                    default:
                        Console.WriteLine("Consultati ......");
                        break;
                }
            }
        }
    }
}
