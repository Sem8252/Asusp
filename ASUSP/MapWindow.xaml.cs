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
using System.Threading;

namespace ASUSP
{
    /// <summary>
    /// Логика взаимодействия для MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        public MapWindow()
        {
            InitializeComponent();
            Navigation.iceBricks.Add(new MapSquare(1, 1, false));
            Navigation.iceBricks.Add(new MapSquare(1, 2, false));
            Navigation.iceBricks.Add(new MapSquare(1, 3, false));
            Navigation.iceBricks.Add(new MapSquare(1, 4, false));
            Navigation.iceBricks.Add(new MapSquare(4, 1, false));
            Navigation.iceBricks.Add(new MapSquare(4, 2, false));
            Navigation.iceBricks.Add(new MapSquare(4, 3, false));
            Navigation.iceBricks.Add(new MapSquare(4, 4, false));

            Navigation.specialBricks.Add(new MapSquare(1, 5, false));
            Navigation.specialBricks.Add(new MapSquare(1, 6, false));
            Navigation.specialBricks.Add(new MapSquare(1, 7, false));
            Navigation.specialBricks.Add(new MapSquare(1, 8, false));
            Navigation.specialBricks.Add(new MapSquare(4, 5, false));
            Navigation.specialBricks.Add(new MapSquare(4, 6, false));
            Navigation.specialBricks.Add(new MapSquare(4, 7, false));
            Navigation.specialBricks.Add(new MapSquare(4, 8, false));

            Navigation.commonBricks.Add(new MapSquare(6, 1, false));
            Navigation.commonBricks.Add(new MapSquare(6, 2, false));
            Navigation.commonBricks.Add(new MapSquare(6, 3, false));
            Navigation.commonBricks.Add(new MapSquare(6, 4, false));
            Navigation.commonBricks.Add(new MapSquare(6, 5, false));
            Navigation.commonBricks.Add(new MapSquare(6, 6, false));
            Navigation.commonBricks.Add(new MapSquare(6, 7, false));
            Navigation.commonBricks.Add(new MapSquare(6, 8, false));
            Navigation.commonBricks.Add(new MapSquare(8, 1, false));
            Navigation.commonBricks.Add(new MapSquare(8, 2, false));
            Navigation.commonBricks.Add(new MapSquare(8, 3, false));
            Navigation.commonBricks.Add(new MapSquare(8, 4, false));
            Navigation.commonBricks.Add(new MapSquare(8, 5, false));
            Navigation.commonBricks.Add(new MapSquare(8, 6, false));
            Navigation.commonBricks.Add(new MapSquare(8, 7, false));
            Navigation.commonBricks.Add(new MapSquare(8, 8, false));
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var current in Navigation.transactionOrder) 
            {
                int type = current.cell.type;
                Random r = new Random();
                int x = 0;
                int y = 0;
                switch(type)
                {
                    case 0:
                        int rand = r.Next(Navigation.commonBricks.Count - 1);
                        x = Navigation.commonBricks[rand].y;
                        y = Navigation.commonBricks[rand].x;
                        Navigation.commonBricks.RemoveAt(rand);
                        break;
                    case 1:
                        int rand2 = r.Next(Navigation.iceBricks.Count - 1);
                        x = Navigation.iceBricks[rand2].y;
                        y = Navigation.iceBricks[rand2].x;
                        Navigation.iceBricks.RemoveAt(rand2);
                        break;
                    case 2:
                        int rand3 = r.Next(Navigation.specialBricks.Count - 1);
                        x = Navigation.specialBricks[rand3].y;
                        y = Navigation.specialBricks[rand3].x;
                        Navigation.iceBricks.RemoveAt(rand3);
                        break;
                    default:
                        break;
                }
                if (Transporter1.Margin.Top + Transporter1.Margin.Left > Transporter2.Margin.Top + Transporter2.Margin.Left)
                {
                    Canvas.SetLeft(Transporter1, 10 + x * 35);
                    Canvas.SetTop(Transporter1, 10 + y * 36);
                }
                else
                {
                    Canvas.SetLeft(Transporter2, 10 + x * 35);
                    Canvas.SetTop(Transporter2, 10 + y * 36);
                }
                await Task.Delay(1000);
            }
            Navigation.transactionOrder.Clear();
        }
    }
}
