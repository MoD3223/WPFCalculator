﻿using System;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
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
            Variables.Zero = false;
            lbl1.Content = Variables.Input;
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!Variables.Input.Contains(","))
            {
                Variables.Input += ",";
                lbl1.Content = Variables.Input;
            }
            else
            {

            }


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
            Variables.LastReset();
            Variables.LastAdd = true;



            if (Variables.Input.Contains(",") || Variables.ResultD1 != 0)
            {
                if (Variables.ResultD1 != 0)
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD2))
                    {
                        Variables.ResultD1 = Variables.AddD(Variables.ResultD1, Variables.ResultD2);
                        lbl1.Content = Variables.ResultD1;
                        Variables.Input = "0";
                        Variables.ResultD2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
                else if (Variables.Result1 != 0)
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD2))
                    {
                        Variables.ResultD1 = Variables.Result1;
                        Variables.ResultD1 = Variables.AddD(Variables.ResultD1, Variables.ResultD2);
                        lbl1.Content = Variables.ResultD1;
                        Variables.Input = "0";
                        Variables.Result1 = 0;
                        Variables.ResultD2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
                else
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD1))
                    {
                        Variables.Input = "0";
                        lbl1.Content = Variables.Input;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
            }
            else
            {
                if (Variables.Result1 != 0)
                {
                    if (Int64.TryParse(Variables.Input, out Variables.Result2))
                    {
                        Variables.Result1 = Variables.AddL(Variables.Result1, Variables.Result2);
                        lbl1.Content = Variables.Result1;
                        Variables.Input = "0";
                        Variables.Result2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToLong;
                    }
                }
                else
                {

                    if (Int64.TryParse(Variables.Input, out Variables.Result1))
                    {
                        Variables.Input = "0";
                        lbl1.Content = Variables.Input;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToLong;
                    }

                }
            }
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            Variables.LastReset();
            Variables.LastSub = true;


            if (Variables.Input.Contains(",") || Variables.ResultD1 != 0)
            {
                if (Variables.ResultD1 != 0)
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD2))
                    {
                        Variables.ResultD1 = Variables.SubD(Variables.ResultD1, Variables.ResultD2);
                        lbl1.Content = Variables.ResultD1;
                        Variables.Input = "0";
                        Variables.ResultD2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
                else if (Variables.Result1 != 0)
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD2)) 
                    {
                        Variables.ResultD1 = Variables.Result1;
                        Variables.ResultD1 = Variables.SubD(Variables.ResultD1, Variables.ResultD2);
                        lbl1.Content = Variables.ResultD1;
                        Variables.Input = "0";
                        Variables.Result1 = 0;
                        Variables.ResultD2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
                else
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD1))
                    {
                        Variables.Input = "0";
                        lbl1.Content = Variables.Input;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
            }
            else
            {
                if (Variables.Result1 != 0)
                {
                    if (Int64.TryParse(Variables.Input, out Variables.Result2))
                    {
                        Variables.Result1 = Variables.SubL(Variables.Result1, Variables.Result2);
                        lbl1.Content = Variables.Result1;
                        Variables.Input = "0";
                        Variables.Result2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToLong;
                    }
                }
                else
                {
                    if (Int64.TryParse(Variables.Input, out Variables.Result1))
                    {
                        Variables.Input = "0";
                        lbl1.Content = Variables.Input;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToLong;
                    }
                }
            }
        }

        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {
            Variables.LastReset();
            Variables.LastMult = true;

            if (Variables.Input.Contains(",") || Variables.ResultD1 != 0)
            {
                if (Variables.ResultD1 != 0)
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD2))
                    {
                        Variables.ResultD1 = Variables.MultD(Variables.ResultD1, Variables.ResultD2);
                        lbl1.Content = Variables.ResultD1;
                        Variables.Input = "0";
                        Variables.ResultD2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
                else if (Variables.Result1 != 0)
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD2))
                    {
                        Variables.ResultD1 = Variables.Result1;
                        Variables.ResultD1 = Variables.MultD(Variables.ResultD2, Variables.ResultD2);
                        lbl1.Content = Variables.ResultD1;
                        Variables.Input = "0";
                        Variables.Result1 = 0;
                        Variables.ResultD2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
                else
                {
                    if (Double.TryParse(Variables.Input, out Variables.ResultD1))
                    {
                        Variables.Input = "0";
                        lbl1.Content = Variables.Input;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToDouble;
                    }
                }
            }
            else
            {
                if (Variables.Result1 != 0)
                {
                    if (Int64.TryParse(Variables.Input, out Variables.Result2))
                    {
                        Variables.Result1 = Variables.MultL(Variables.Result1, Variables.Result2);
                        lbl1.Content = Variables.Result1;
                        Variables.Input = "0";
                        Variables.Result2 = 0;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToLong;
                    }
                }
                else
                {
                    if (Int64.TryParse(Variables.Input, out Variables.Result1))
                    {
                        Variables.Input = "0";
                        lbl1.Content = Variables.Input;
                    }
                    else
                    {
                        lbl1.Content = Variables.PFailedToLong;
                    }
                }
            }
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Variables.LastReset();
            Variables.LastInputReset();
            Variables.Clear();

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

        private void BtnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Variables.Input.Contains("-"))
            {
                Variables.Input = Variables.Input.Remove(0, 1);
            }
            else
            {
                Variables.Input = "-" + Variables.Input;
            }
            lbl1.Content = Variables.Input;
        }
    }
}
