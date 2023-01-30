using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineCompison lineCompison = new LineCompison();
            lineCompison.LinelengthCompison();
           // lineCompison.checkRelation();
            lineCompison.lengthCalculate();
            lineCompison.ifEquals();
        }
    }
}

            
     