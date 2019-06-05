using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    abstract class Person
    {
        private string name;
        private string surname;
        private int idNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int IdNumber { get => idNumber; set => idNumber = value; }

        public Person(string name,string surname,int idNumber)
        {
            this.name = name;
            this.surname = surname;
            this.idNumber = idNumber;
        }
    }
}
