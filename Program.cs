using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson;

namespace Refactoring_and_Testing_06_09_21_
{
    class Program
    {
        static void Main(string[] args)
        {
           var res1 = Helper.CalculatePercentageGuardFailFast("150", "25");
            Console.WriteLine(res1 + "%");
        }
    }
}
