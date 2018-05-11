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
            line1_1.Text = Convert.ToString(Logic.Data[0].productCode);
            line1_2.Text = Convert.ToString(Logic.Data[0].startDate);
            line1_3.Text = Convert.ToString(Logic.Data[0].expiryDate);
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
        }
    }
}
