using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class SeatsInTheater
    {
        public static int SeatsInTheaterMethod(int nCols, int nRows, int col, int row)
        {
            return (nCols - (col - 1)) * (nRows - row);
            
            
        }
    }
}
