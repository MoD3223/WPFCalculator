using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WPFCalculator;
using System.Windows.Controls;
using Microsoft.

namespace WPFCalculator
{
    class Variables
    {
        //Longs
        public static long AddL(long k, long j)
        {
            long l;
            l = k + j;

            return l;
        }
        public static long SubL(long k, long j)
        {
            return k - j;
        }
        public static long MultL(long k, long j)
        {
            return k * j;
        }
        public static long DivL(long k, long j)
        {
            return k / j;
        }

        //Doubles
        public static double AddD(double k, double j)
        {
            return k + j;
        }
        public static double SubD(double k, double j)
        {
            return k - j;
        }
        public static double MultD(double k, double j)
        {
            return k * j;
        }
        public static double DivD(double k, double j)
        {
            return k / j;
        }

        public static string Input = "0";
        public static long Result1;
        public static long Result2;

        public static double ResultD1;
        public static double ResultD2;

        public static bool Zero;

        public static bool LastInputAdd;
        public static bool LastInputSub;
        public static bool LastInputMult;
        public static bool LastInputDiv;

        public static string PFailedToLong = "Error! Number too high.";
        public static string PFailedToDouble = "Error! Can't parse the number.";


        public static void LastInputReset()
        {
            LastInputAdd = false;
            LastInputSub = false;
            LastInputMult = false;
            LastInputDiv = false;
        }

        public static void Clear()
        {
            Result1 = 0;
            Result2 = 0;
            ResultD1 = 0;
            ResultD2 = 0;
            Input = "0";
        }

        public static void Check()
        {
            Debug.WriteLine(Result1);
            Debug.WriteLine(Result2);
            Debug.WriteLine(ResultD1);
            Debug.WriteLine(ResultD2);
        }



        public static double x;
        public static double y;



        public static double Probability(double x, double y)
        {
            x = 1 - x;
            double a = Math.Pow(x, y);
            a = 1 - a;
            return a;

            //1 - ((1 - x) ^ y); //x = chance, y = number of tries (x = 0.2 = 20%)
        }
    }
}