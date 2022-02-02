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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */
     

    // My solution is based on linear function intersection
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
    
        float mDiff = v1 - v2;
        float bDiff = x2 - x1;
        
        float possibleX = bDiff/mDiff;
        
        float fx1 = (v1 * possibleX) + x1;
        float fx2 = (v2 * possibleX) + x2;
        
        if (mDiff <= 0)
        {
            return "NO";
        }
    
        if(fx1 == fx2)
        {
            double rounded = Math.Round(possibleX);

            //Check if they meet in the air or when they have completed the jump.  
            if(possibleX == rounded)
                return "YES";
                     
        }
        
        return "NO";
    }
}