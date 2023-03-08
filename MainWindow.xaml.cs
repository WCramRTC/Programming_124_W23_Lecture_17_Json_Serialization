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
        List<PlayerInformation> players = new List<PlayerInformation>();
        public MainWindow()
        {
            InitializeComponent();


            string listOfPlayers = JsonSerializer.Serialize(players);

            runDisplay.Text = listOfPlayers;
        }


    }
}
