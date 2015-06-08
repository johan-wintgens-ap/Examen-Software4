using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace Final4
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

        ObservableCollection<Personen> PersonenLijst = new ObservableCollection<Personen>();
        private string jsonData;
        private string fileDir = Environment.CurrentDirectory + @"\so4data.json";
        private Rootobject data;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            jsonData = File.ReadAllText(fileDir);
            data = JsonConvert.DeserializeObject<Rootobject>(jsonData);
        }
    }
}
