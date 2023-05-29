using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.IntFuncs;

//learn more https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
public class IntFuncs
{
    public static double Sum(double a, double b)
    {
        return a + b;
    }

    // This method will not pass the test
    public static int Div(int a, int b)
    {
        return a / b;
    }
}
