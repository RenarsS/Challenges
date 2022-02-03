using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
            List<int> roundedGrades = new List<int> ();
            
            foreach(int grade in grades)
            {
                if(grade < 38 || grade % 5 == 0)
                    roundedGrades.Add(grade);
                else 
                    roundedGrades.Add(grade % 5 >= 3 ? (grade/5)*5 + 5 : grade);
            }
            
            return roundedGrades;
    }

}
