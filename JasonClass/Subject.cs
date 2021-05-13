using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonClass
{
    class Subject
    {
        public string name { get; }

        public int NumberOfHourse { get; set; }

        public int Semestr { get; set; }

        public Subject(string name, int numberofHourse, int semestr)
        {
            this.name = name;
            NumberOfHourse = numberofHourse;
            Semestr = semestr;
        }

        public override string ToString()
        {
            return name + ": часов " + NumberOfHourse + "0 семестр " + Semestr;
        }
    }

    class Employee
    {
        static int hourOfStavka = 900;
        static int countOfEmployee = 0;
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public double Stavka { get; set; }

        int hour;
        public int HourOfStavka
        {
            set
            {
                if (value < Stavka * hourOfStavka)
                    hour += value;
                //else
                 //   throw new Exception("слишком много часов");
            }
            get { return hour; }
        }
        List<Subject> ListSubjects = new List<Subject>();

        public Employee(string lastName, string firstName, double stavka)
        {
            LastName = lastName;
            FirstName = firstName;
            Stavka = stavka;
        }

        public void AddSubject(Subject s)
        {
            try
            {
                HourOfStavka += s.NumberOfHourse;
                ListSubjects.Add(s);
            }
            catch
            {
                Debug.WriteLine("Exception: не удалось добавитьб т.к. слишком много часов");
            }
       }
    }
}
