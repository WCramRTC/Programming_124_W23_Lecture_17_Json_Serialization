using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_W23_Lecture_17_Json_Serialization
{
    public class Manager
    {
        string _name;
        double _salary;

        public Manager(string name, double salary)
        {
            _name = name;
            _salary = salary;
        }

        public Manager()
        {
        }

        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; set => _salary = value; }
    }
}
