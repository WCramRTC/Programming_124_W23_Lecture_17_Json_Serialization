using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft;

namespace Programming_124_W23_Lecture_17_Json_Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Name> names = new List<Name>();

        public MainWindow()
        {
            InitializeComponent();

            string filePath = "teamRoster.json";
            string teamString = File.ReadAllText(filePath);
            TeamRoster seahawks = JsonSerializer.Deserialize<TeamRoster>(teamString);

            runDisplay.Text = seahawks.Players[2].ToString();

            // Write Json
            // FIle Path
            // string jsonObject = JsonSerializer.Serialize(object)
            // File.WriteAllText(filePath, jsonObject);

            // Read
            // File Path
            // string fileText = File.ReadAllText(filePath);
            // object deseralizedObject = JsonSerializer.Deserialize<object>(fileText);

        }

        public void SerilizedTeamRoster()
        {
            Manager bander = new Manager("Bander", 1233545456);
            TeamRoster seahawks = new TeamRoster("Seahawks", "Seattle", bander);

            seahawks.AddPlayer(new Player("Zak", "1"));
            seahawks.AddPlayer(new Player("Sam", "2"));
            seahawks.AddPlayer(new Player("Suleman", "3"));

            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonTeam = JsonSerializer.Serialize(seahawks, jso);

            File.WriteAllText("teamRoster.json", jsonTeam);
        }




        #region BinaryExample

        public void BinaryExample()
        {
            string filePath = "names.bin";

            names.Add(new Name("Will", "Password_DontSeeMe"));

            Serialize(names, filePath);
            //Deserialize(filePath);

        }

        public void Serialize(List<Name> name, string filePath )
        {
            //Create the stream to add object into it.  
            System.IO.Stream ms = File.OpenWrite(filePath);
            //Format the object as Binary  

            BinaryFormatter formatter = new BinaryFormatter();
            //It serialize the employee object  
            formatter.Serialize(ms, name);
            ms.Flush();
            ms.Close();
            ms.Dispose();
        }

        public void Deserialize(string filename)
        {
            //Format the object as Binary  
            BinaryFormatter formatter = new BinaryFormatter();

            //Reading the file from the server  
            FileStream fs = File.Open(filename, FileMode.Open);

            object obj = formatter.Deserialize(fs);
            names = (List<Name>)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();
            
        }
        #endregion

        #region JsonExample

        public void JsonExample()
        {
            names.Add(new Name("Bander", "23456"));
            names.Add(new Name("Zach", "56557"));
            names.Add(new Name("Sam", "345347"));
            names.Add(new Name("Suleman", "23345456"));


            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonBander = JsonSerializer.Serialize(names, options);

            runDisplay.Text = jsonBander;

            // ---- Read file back
            // File destination
            string filePath = "listOfName.json";
            // Reads all text from file
            string listFromFile = File.ReadAllText(filePath);
            // COnverts text to List of Name
            names = JsonSerializer.Deserialize<List<Name>>(listFromFile);


            foreach (Name name in names)
            {
                runDisplay.Text += name + "\n";
            }


            //File.WriteAllText(filePath, jsonBander);
        }

        //List<PlayerInformation> players = new List<PlayerInformation>();
        //List<TestClass> tcs = new List<TestClass>();
        //string fileName = "userInfo.json";

        //public void Serialize()
        //{
        //    tcs.Add(new TestClass("Will", "Cram"));
        //    tcs.Add(new TestClass("Anne", "Nguyen"));

        //    JsonSerializerOptions jso = new JsonSerializerOptions()
        //    {
        //        WriteIndented = true
        //    };

        //    string json = JsonSerializer.Serialize(tcs, jso);

        //    runDisplay.Text = json;

        //    File.WriteAllText(fileName, json);
        //}

        //public void Deserialize()
        //{
        //    string jsonString = File.ReadAllText(fileName);
        //    tcs = JsonSerializer.Deserialize<List<TestClass>>(jsonString);

        //    MessageBox.Show(tcs.Count.ToString());
        //}

        //string fileName = "WeatherForecast.json";
        //string jsonString = JsonSerializer.Serialize(weatherForecast);
        //File.WriteAllText(fileName, jsonString);
        #endregion

    }

    // At the top of my class, I add whats known as a data annotation
    // [Serializable]
 
    public class Name
    {
        string _userName;

        //[NonSerialized]
        string _password;

        public Name(string name, string password)
        {
            _userName = name;
            _password = password;
        }

        public Name()
        {

        }

        public string Password { get => _password; set => _password = value; }
        public string UserName { get => _userName; set => _userName = value; }
  

        public override string ToString()
        {
            return $"{UserName}";
        }
    }
}
