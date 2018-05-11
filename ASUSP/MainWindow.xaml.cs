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

namespace ASUSP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Logic.Data = DataConvert.ReadFromCSV();
            Logic.StartLine = 0;
            UpdateVisualization();
            //Transaction test = new Transaction(2012, 12, 21, 2017, 05, 21, ProductTypes.Common, 4277,
            //    "Russia", "Moscow", "MPF", new Cell());
            //List<Transaction> TestList = new List<Transaction>();
            //TestList.Add(test);
            //DataConvert.WriteToCSV(TestList);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataWindow DataStorage = new DataWindow();
            DataStorage.Show();
        }

        private void OpenMap_Click(object sender, RoutedEventArgs e)
        {
            MapWindow Map = new MapWindow();
            Map.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Transaction newTransaction = Logic.AddFromScreen(StartDateBox.Text, ExpDateBox.Text, TypeBox.SelectedIndex, CodeBox.Text,
                CountryBox.Text, CityBox.Text, FirmBox.Text, CellTypeBox.SelectedIndex);
            Logic.Data.Add(newTransaction);
            DataConvert.WriteToCSV(Logic.Data);
            MessageBox.Show("Успех");
            UpdateVisualization();
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if(Logic.StartLine>0)
            Logic.StartLine--;
            UpdateVisualization();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            Logic.StartLine++;
            UpdateVisualization();
        }

        protected void UpdateVisualization()
        {
            if (Logic.Data.Count - Logic.StartLine - 0 > 0)
            {
                line1_1.Text = Convert.ToString(Logic.Data[Logic.StartLine].productCode);
                line1_2.Text = Convert.ToString(Logic.Data[Logic.StartLine].startDate);
                line1_3.Text = Convert.ToString(Logic.Data[Logic.StartLine].expiryDate);
            }
            else
            {
                line1_1.Text = "";
                line1_2.Text = "";
                line1_3.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 1 > 0)
            {
                line2_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].productCode);
                line2_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].startDate);
                line2_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].expiryDate);
            }
            else
            {
                line2_1.Text = "";
                line2_2.Text = "";
                line2_3.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 2 > 0)
            {
                line3_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].productCode);
                line3_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].startDate);
                line3_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].expiryDate);
            }
            else
            {
                line3_1.Text = "";
                line3_2.Text = "";
                line3_3.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 3 > 0)
            {
                line4_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].productCode);
                line4_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].startDate);
                line4_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].expiryDate);
            }
            else
            {
                line4_1.Text = "";
                line4_2.Text = "";
                line4_3.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 4 > 0)
            {
                line5_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].productCode);
                line5_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].startDate);
                line5_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].expiryDate);
            }
            else
            {
                line5_1.Text = "";
                line5_2.Text = "";
                line5_3.Text = "";
            }
        }
    }
}
