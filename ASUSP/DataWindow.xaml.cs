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
using System.Windows.Shapes;

namespace ASUSP
{
    /// <summary>
    /// Логика взаимодействия для DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        public DataWindow()
        {
            InitializeComponent();
            UpdateVisualization();
        }

        protected void UpdateVisualization()
        {
            if (Logic.Data.Count - Logic.StartLine - 0 > 0)
            {
                box1_1.Text = Convert.ToString(Logic.Data[Logic.StartLine].productCode);
                box1_2.Text = Convert.ToString(Logic.Data[Logic.StartLine].startDate);
                box1_3.Text = Convert.ToString(Logic.Data[Logic.StartLine].expiryDate);
                box1_4.Text = Convert.ToString(Logic.Data[Logic.StartLine].country);
                box1_5.Text = Convert.ToString(Logic.Data[Logic.StartLine].city);
                box1_6.Text = Convert.ToString(Logic.Data[Logic.StartLine].firm);
                box1_7.Text = Convert.ToString(Logic.Data[Logic.StartLine].status);
            }
            else
            {
                box1_1.Text = "";
                box1_2.Text = "";
                box1_3.Text = "";
                box1_4.Text = "";
                box1_5.Text = "";
                box1_6.Text = "";
                box1_7.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 1 > 0)
            {
                box2_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].productCode);
                box2_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].startDate);
                box2_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].expiryDate);
                box2_4.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].country);
                box2_5.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].city);
                box2_6.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].firm);
                box2_7.Text = Convert.ToString(Logic.Data[Logic.StartLine + 1].status);
            }
            else
            {
                box2_1.Text = "";
                box2_2.Text = "";
                box2_3.Text = "";
                box2_4.Text = "";
                box2_5.Text = "";
                box2_6.Text = "";
                box2_7.Text = "";

            }
            if (Logic.Data.Count - Logic.StartLine - 2 > 0)
            {
                box3_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].productCode);
                box3_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].startDate);
                box3_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].expiryDate);
                box3_4.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].country);
                box3_5.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].city);
                box3_6.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].firm);
                box3_7.Text = Convert.ToString(Logic.Data[Logic.StartLine + 2].status);
            }
            else
            {
                box3_1.Text = "";
                box3_2.Text = "";
                box3_3.Text = "";
                box3_4.Text = "";
                box3_5.Text = "";
                box3_6.Text = "";
                box3_7.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 3 > 0)
            {
                box4_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].productCode);
                box4_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].startDate);
                box4_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].expiryDate);
                box4_4.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].country);
                box4_5.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].city);
                box4_6.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].firm);
                box4_7.Text = Convert.ToString(Logic.Data[Logic.StartLine + 3].status);
            }
            else
            {
                box4_1.Text = "";
                box4_2.Text = "";
                box4_3.Text = "";
                box4_4.Text = "";
                box4_5.Text = "";
                box4_6.Text = "";
                box4_7.Text = "";
            }
            if (Logic.Data.Count - Logic.StartLine - 4 > 0)
            {
                box5_1.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].productCode);
                box5_2.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].startDate);
                box5_3.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].expiryDate);
                box5_4.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].country);
                box5_5.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].city);
                box5_6.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].firm);
                box5_7.Text = Convert.ToString(Logic.Data[Logic.StartLine + 4].status);
            }
            else
            {
                box5_1.Text = "";
                box5_2.Text = "";
                box5_3.Text = "";
                box5_4.Text = "";
                box5_5.Text = "";
                box5_6.Text = "";
                box5_7.Text = "";
            }
        }

        private void UpButtonData_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.StartLine > 0)
                Logic.StartLine--;
            UpdateVisualization();
        }

        private void DownButtonData_Click(object sender, RoutedEventArgs e)
        {
            Logic.StartLine++;
            UpdateVisualization();
        }

        private void Delete1_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.Data.Count - Logic.StartLine - 0 > 0 && Logic.Data[Logic.StartLine].status != true)
            {
                Logic.Data.RemoveAt(Logic.StartLine);
                UpdateVisualization();
                DataConvert.WriteToCSV(Logic.Data);
            }
        }

        private void Delete2_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.Data.Count - Logic.StartLine - 1 > 0 && Logic.Data[Logic.StartLine+1].status != true)
            {
                Logic.Data.RemoveAt(Logic.StartLine+1);
                UpdateVisualization();
                DataConvert.WriteToCSV(Logic.Data);
            }
        }

        private void Delete3_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.Data.Count - Logic.StartLine - 2 > 0 && Logic.Data[Logic.StartLine+2].status != true)
            {
                Logic.Data.RemoveAt(Logic.StartLine+2);
                UpdateVisualization();
                DataConvert.WriteToCSV(Logic.Data);
            }
        }

        private void Delete4_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.Data.Count - Logic.StartLine - 3 > 0 && Logic.Data[Logic.StartLine+3].status != true)
            {
                Logic.Data.RemoveAt(Logic.StartLine+3);
                UpdateVisualization();
                DataConvert.WriteToCSV(Logic.Data);
            }
        }

        private void Delete5_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.Data.Count - Logic.StartLine - 4 > 0 && Logic.Data[Logic.StartLine+4].status != true)
            {
                Logic.Data.RemoveAt(Logic.StartLine+4);
                UpdateVisualization();
                DataConvert.WriteToCSV(Logic.Data);
            }
        }
    }
}
