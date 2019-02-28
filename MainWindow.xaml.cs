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

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbl1.Content = Variables.Input;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "7";
            }
            else
            {
                Variables.Input += "7";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "8";
            }
            else
            {
                Variables.Input += "8";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "9";
            }
            else
            {
                Variables.Input += "9";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "4";
            }
            else
            {
                Variables.Input += "4";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "5";
            }
            else
            {
                Variables.Input += "5";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "6";
            }
            else
            {
                Variables.Input += "6";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "1";
            }
            else
            {
                Variables.Input += "1";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "2";
            }
            else
            {
                Variables.Input += "2";
            }
            lbl1.Content = Variables.Input;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0")
            {
                Variables.Input = "3";
            }
            else
            {
                Variables.Input += "3";
            }
            lbl1.Content = Variables.Input;
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input == "0" && Variables.Zero == false)
            {
                Variables.Zero = true;
            }
            //I could've used straight else with if input = 0/bool = true but added it just to be safe
            if (Variables.Input == "0" && Variables.Zero == true)
            {
                Variables.Input += "0";
            }
            else
            {
                Variables.Input += "0";
            }
            lbl1.Content = Variables.Input;
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Variables.Input = Variables.Input.Substring(0, Variables.Input.Length -1);
            if (Variables.Input.Length == 0)
            {
                Variables.Input += "0";
            }
            lbl1.Content = Variables.Input;
        }

        private void BtnMinusOne_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
