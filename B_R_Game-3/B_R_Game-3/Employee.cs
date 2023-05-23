using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_R_Game_3
{
    internal class Employee
    {
        private string _FIO;
        private string _Gender;
        private double _Salary;
        private double _Id;
        private double _Departament;
        private string _Description;
        private double count;

        public Employee(string _fio, string gender, double salary, double departament, string description)
        {
            _FIO = fio;
            _Id = count++;
            _Gender = gender;
            _Salary = salary;
            _Description = description;
        }

        public string fio
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public string Gender
        {
            get => _Gender;
            set => _Gender = value;
        }

        public double Salary
        {
            get => _Salary;
            set => _Salary = value;
        }

        public double Departament
        {
            get => _Departament;
            set => _Departament = value;
        }

        public string Description
        {
            get => _Description;
            set => _Description = value;
        }

    }
}
