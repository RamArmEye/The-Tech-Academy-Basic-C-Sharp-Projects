using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Define a generic Employee class that takes a type parameter T.
    public class Employee<T>
    {
        // Declare a property "Things" that is a list of type T.
        public List<T> Things { get; set; }
    }
}