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
            


            
        }

        #region Example

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
}
