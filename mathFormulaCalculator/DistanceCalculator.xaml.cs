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

namespace mathFormulaCalculator
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        //Gives Distance
        private void SolveDistance_Click(object sender,RoutedEventArgs e)
        {
            string X1String = X1.Text;
            string X2String = X2.Text;
            string Y1String = Y1.Text;
            string Y2String = Y2.Text;
            string DistanceString;
            
            
            if ((X1String == "") && (X2String == "") && (Y1String == "") && (Y2String == ""))
            {
                MessageBox.Show("Please enter all X and Y Coordinates.");
            }
            else
            {
                if((X1String != "") && (X2String != "") && (Y1String != "") && (Y2String != ""))
                {
                    double x1 = double.Parse(X1String);
                    double x2 = double.Parse(X1String);
                    double y1 = double.Parse(X1String);
                    double y2 = double.Parse(X1String);
                    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    distance = Math.Round(distance, 3);
                    DistanceString = distance.ToString();
                    MessageBox.Show("The distance between the two points is " + DistanceString);
                   
                }
            }
        }
    }
}
