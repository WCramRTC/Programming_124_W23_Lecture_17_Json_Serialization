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
   

        public MainWindow()
        {
            InitializeComponent();

            Name name = new Name("Will");

            Serialize(name, "nameBinary.bin");
            
            
        }

        #region BinaryExample

        public void Serialize(Name name, string filePath )
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
            Name name = (Name)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();
            MessageBox.Show(name.UserName);
        }
        #endregion

        #region JsonExample

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

    [Serializable]
    public class Name
    {
        string _userName;

        public Name(string name)
        {
            _userName = name;
        }

        public string UserName { get => _userName; set => _userName = value; }
    }
}
