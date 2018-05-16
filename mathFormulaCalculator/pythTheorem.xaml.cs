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

namespace mathFormulaCalculator
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void solveForHypotenuse_Click(object sender, RoutedEventArgs e)
        {
            string aString = aText.Text;
            string bString = bText.Text;
            string hypString = hypotenuseText.Text;

            if ((hypString == "") && (aString == "" || bString == ""))
            {
                MessageBox.Show("Please enter a value for hypotenuse or one of the legs");
            }
            else
            {
                double c = double.Parse(hypString);
                if ((aString != "") && (bString != ""))
                {
                    MessageBox.Show("Please only enter one leg value");
                }
                else
                {
                    if (aString != "")
                    {
                        double a = double.Parse(aString);
                        a = Math.Pow(a, 2);
                        c = Math.Pow(c, 2);
                        double b = c - a;
                        b = Math.Sqrt(b);
                        b = Math.Round(b, 3);
                        bString = b.ToString();
                        bText.Text = bString;
                        MessageBox.Show("The length of the other leg of this triangle (b) is " + bString);
                    }
                    else if (bString != "")
                    {
                        double b = double.Parse(bString);
                        b = Math.Pow(b, 2);
                        c = Math.Pow(c, 2);
                        double a = c - b;
                        a = Math.Sqrt(a);
                        a = Math.Round(a, 3);
                        aString = a.ToString();
                        aText.Text = aString;
                        MessageBox.Show("The length of the other leg of this triangle (a) is " + aString);
                    }
                }
            }
        }
        //solves for hypotenuse
        private void solveForHypotenuse_Click_1(object sender, RoutedEventArgs e)
        {
            string aString = aText.Text;
            string bString = bText.Text;
            string hypString = hypotenuseText.Text;

            if ((aString == "" && bString == "") && (hypString != ""))
            {
                MessageBox.Show("Please enter a value for both of the legs or remove the hypotenuse");
            }
            else
            {
                double a = double.Parse(aString);
                double b = double.Parse(bString);
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                double c = a + b;
                c = Math.Sqrt(c);
                c = Math.Round(c, 3);
                hypString = c.ToString();
                hypotenuseText.Text = hypString;
                MessageBox.Show("The length of the hypotenuse of this triangle (c) is " + hypString);
            }
        }
    }
}
