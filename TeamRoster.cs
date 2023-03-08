using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_W23_Lecture_17_Json_Serialization
{

    internal class TeamRoster
    {
        string _name;
        string _city;
        Manager _manger;
        List<Player> _players = new List<Player>();

        public TeamRoster(string name, string city, Manager manger)
        {
            _name = name;
            _city = city;
            _manger = manger;
        }

        // User for the jsondeserializer
        public TeamRoster()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public Manager Manger { get => _manger; set => _manger = value; }
        public List<Player> Players { get => _players; set => _players = value; }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }
    }
}
