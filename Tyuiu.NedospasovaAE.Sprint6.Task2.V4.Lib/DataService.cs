﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedospasovaAE.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; 
            int len = (stopValue - startValue) + 1; 
            valueArray = new double[len]; 
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 2;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2, 2);
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
