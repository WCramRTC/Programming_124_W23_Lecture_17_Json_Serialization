using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_W23_Lecture_17_Json_Serialization
{
    public class Player
    {

        string _name;
        string _number;

        public string Name { get => _name; set => _name = value; }
        public string Number { get => _number; set => _number = value; }

        public Player(string name, string number)
        {
            _name = name;
            _number = number;
        }

        public Player()
        {
        }

        public override string ToString()
        {
            return $"{_name} - {_number}";
        }
    }
}
