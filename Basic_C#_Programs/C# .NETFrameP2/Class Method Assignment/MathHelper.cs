using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{ 
// Static class for mathematical helper methods
static class MathHelper
{
    // Static method to perform division with output parameters
    public static void GetDivisionDetails(int input, out int half, out int remainder)
    {
        half = input / 2;        // Integer division by 2
        remainder = input % 2;   // Gets remainder to show if number was odd or even
    }
}
}

