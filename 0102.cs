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
    // Rather than brute force checking

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
    
        double mDiff = v1 - v2;
        double bDiff = x2 - x1;
        
        double possibleX = bDiff/mDiff;
        
        double fx1 = (v1 * possibleX) + x1;
        double fx2 = (v2 * possibleX) + x2;
        
        if (mDiff <= 0)
        {
            return "NO";
        } 
        else{
            if(fx1 == fx2)
            {
                double rounded = Math.Round(possibleX);
                
                //Checks if they meet when they land or when that are in a jump
                if(possibleX == rounded)
                    return "YES";
                     
                return "NO";
            }
            return "NO";
            
        }
        return "YES";
    }
}