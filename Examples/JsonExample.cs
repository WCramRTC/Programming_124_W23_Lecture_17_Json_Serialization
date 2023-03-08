using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Programming_124_W23_Lecture_17_Json_Serialization.Examples
{
    internal class JsonExample
    {
        //public void Preload()
        //{
        //    players.Add(new PlayerInformation("Player 1", 1, "Info about player 1"));
        //    players.Add(new PlayerInformation("Player 2", 2, "Info about player 2"));
        //    players.Add(new PlayerInformation("Player 3", 3, "Info about player 3"));
        //    players.Add(new PlayerInformation("Player 4", 4, "Info about player 4"));
        //    players.Add(new PlayerInformation("Player 5", 5, "Info about player 5"));
        //}

        public void FormattedJson()
        {

            PlayerInformation player1 = new PlayerInformation("Will", 100, "He is a professor at Renton Technical College");
            string fileName2 = "playerSerialized.json";
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };



            string jsonString = JsonSerializer.Serialize(player1, options);
            //runDisplay.Text = jsonString;
        }

        public void SaveJsonBasic()
        {

            PlayerInformation player1 = new PlayerInformation("Will", 100, "He is a professor at Renton Technical College");

            string fileName = "player.json";
            string jsonString = JsonSerializer.Serialize(player1);
            //File.WriteAllText(fileName, jsonString);

            // runDisplay.Text = jsonString; 
        }
    }
}
