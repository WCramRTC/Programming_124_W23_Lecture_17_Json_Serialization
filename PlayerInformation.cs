using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_W23_Lecture_17_Json_Serialization
{
    internal class PlayerInformation
    {
        string _name;
        int _hp;
        string _bio;

        public PlayerInformation(string name, int hp, string bio)
        {
            _name = name;
            _hp = hp;
            _bio = bio;
        }

        public string Name { get => _name; set => _name = value; }
        public int Hp { get => _hp; set => _hp = value; }
        public string Bio { get => _bio; set => _bio = value; }
    }
}
