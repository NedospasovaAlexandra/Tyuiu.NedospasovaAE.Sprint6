using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NedospasovaAE.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] temp = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                temp[i] = matrix[i, columns - 3];
            }
            Array.Sort(temp);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, columns - 3] = temp[i];
            }
            return matrix;
        }
    }
}
