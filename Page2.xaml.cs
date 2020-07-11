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
    /// Interaction logic for More.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void BtnCalcPow_Click(object sender, RoutedEventArgs e)
        {
            CalcPow();
        }




        public void CalcPow()
        {
            if (Double.TryParse(txtPow1.Text, out Variables2.xPow))
            {
                Variables2.xParsed = true;
            }
            else
            {
                txtPow1.Text = Variables.PFailedToDouble;
                Variables2.xParsed = false;
            }

            if (Double.TryParse(txtPow2.Text, out Variables2.yPow))
            {
                Variables2.yParsed = true;
            }
            else
            {
                txtPow2.Text = Variables.PFailedToDouble;
                Variables2.yParsed = false;
            }


            if (Variables2.xParsed && Variables2.yParsed == true)
            {


                Variables2.PowStringResult = Variables2.Probability(Variables2.xPow, Variables2.yPow).ToString();
                Variables2.PowStringResult += "%";
                PowResult.Content = Variables2.PowStringResult;
                
            }



        }

    }
}
