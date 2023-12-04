using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Method
    {
        // Creating a method with two integers as parameters
        // Making one integer optional by giving it a default value
        public int MultiOp(int a, int b = 18) 
        {
            // Multiplying the integers between each other and returning the result
            int result = a * b;
            return result;
        }
    }
}
