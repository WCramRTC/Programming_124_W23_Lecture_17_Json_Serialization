using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_W23_Lecture_17_Json_Serialization.Examples
{
    internal class TestClass
    {
        string _name;
        string _lastName;
        List<int> grades = new List<int>();

        public TestClass(string name, string lastName)
        {
            Random rand = new Random();
            _name = name;
            _lastName = lastName;

            for (int i = 0; i < 10; i++)
            {
                grades.Add(rand.Next(0, 101));
            }

        }

        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public List<int> Grades { get => grades; set => grades = value; }
    }
}
