﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    class Variables
    {
        //Longs
        public static long AddL(long k, long j)
        {
            return k + j;
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
        public static long Result3;

        public static double ResultD1;
        public static double ResultD2;
        public static double ResultD3;

        public static bool Zero;
        public static bool LastAdd;
        public static bool LastSub;
        public static bool LastMult;
        public static bool LastDiv;




    }
}
