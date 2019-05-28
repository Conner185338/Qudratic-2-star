/*
 * Conner Warboys
 * May 24th, 2019
 * Gets roots of function and graphs parabola
 * ICS3U
 */
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

namespace u5Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables
        double descriminant = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            //Values of a, b and c
            int IndexX = txtStatement.Text.IndexOf("x");
            string Input = txtStatement.Text;

            //A 
            double A = 0;
            string Value1 = Input.Substring(0, IndexX);
            int previousPosX = IndexX;
            IndexX = txtStatement.Text.IndexOf("x", IndexX + 1);

            //B 
            double B = 0;
            string Value2 = Input.Substring(previousPosX + 5, IndexX - previousPosX - 5);
            int indexOfEqual = txtStatement.Text.IndexOf("=");

            //C
            double C = 0;
            string Value3 = Input.Substring(IndexX + 4, indexOfEqual - IndexX - 5);

            //Using double for values to store decimals
            double.TryParse(Value1, out A);
            double.TryParse(Value2, out B);
            double.TryParse(Value3, out C);

            descriminant = Math.Sqrt((B * B) - (4 * A * C));

            double Root1 = (-B + descriminant) / (2 * A);
            lblOutput.Content = "Root #1 " + Root1.ToString() + "        ";

            double Root2 = (-B - descriminant) / (2 * A);
            lblOutput.Content += "Root #2 " + Root2.ToString();
            }
        }
    }


