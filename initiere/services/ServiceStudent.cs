using initiere_teorie.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere_teorie.services
{
    public class ServiceStudent
    {
        private List<Student> _studentsList;

        public ServiceStudent()
        {
            Student student1 = new Student("Ion", "Popescu", 15, 9, "Math", true);
            Student student2 = new Student("Alex", "Sandru", 17, 11, "Science", false);
            Student student3 = new Student("Diana", "Bogdan", 16, 10, "Philosophy", true);
            Student student4 = new Student("Radu", "Bocu", 18, 12, "Informatics", true);
            Student student5 = new Student("Dorian", "Popa", 18, 12, "Bussiness", true);
            Student student6 = new Student("Gabriel", "Dan", 14, 9, "Math", false);
            Student student7 = new Student("Marcus", "Dan", 14, 9, "Math", false);

            _studentsList = new List<Student>();

            _studentsList.Add(student1);
            _studentsList.Add(student2);
            _studentsList.Add(student3);
            _studentsList.Add(student4);
            _studentsList.Add(student5);
            _studentsList.Add(student6);
            _studentsList.Add(student7);
        }
        public void ShowStudents()
        {
            for (int i = 0; i < _studentsList.Count; i++)
            {

                _studentsList[i].GetStudentDescription();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
        public void alphabeticalSort()
        {
            for(int i=0; i < _studentsList.Count - 1;i++)
            {
                for(int j= i+1;j < _studentsList.Count;j++)
                    if (_studentsList[i].GetName().Equals((_studentsList[j].GetName())))
                    {
                        Student aux = _studentsList[i];
                        _studentsList[i] = _studentsList[j];
                        _studentsList[j] = aux;
                    }

            }
            
           
        }

        public void ShowFailedStudents()
        {

            for (int i = 0; i < _studentsList.Count; i++)
            {
                if (_studentsList[i].GetHasPassed() == false)
                {
                    _studentsList[i].GetStudentDescription();
                }

            }
        }
        public void ShowPassedStudents()
        {

            for (int i = 0; i < _studentsList.Count; i++)
            {
                if (_studentsList[i].GetHasPassed() == true)
                {
                    _studentsList[i].GetStudentDescription();
                }

            }
        }
        public void SortStudentsAscendingByAge()
        {
            for (int i = 0; i < _studentsList.Count - 1; i++)
            {
                for (int j = i + 1; j < _studentsList.Count; j++)
                {
                    if (_studentsList[i].GetAge() > _studentsList[j].GetAge())
                    {

                        Student aux = _studentsList[i];
                        _studentsList[i] = _studentsList[j];
                        _studentsList[j] = aux;
                    }
                }
            }
        }
        public void SortStudentsDescendingByAge()
        {
            for (int i = 0; i < _studentsList.Count - 1; i++)
            {
                for (int j = i + 1; j < _studentsList.Count; j++)
                {
                    if (_studentsList[i].GetAge() < _studentsList[j].GetAge())
                    {

                        Student aux = _studentsList[i];
                        _studentsList[i] = _studentsList[j];
                        _studentsList[j] = aux;
                    }
                }
            }
        }
        public void ShowProfile(String profile)
        {
            for (int i = 0; i < _studentsList.Count; i++)
                if (_studentsList[i].GetProfile() == profile)
                {
                    _studentsList[i].GetStudentDescription();
                    Console.WriteLine("================================================");
                }

        }
    }
}
