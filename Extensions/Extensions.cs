using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        static public bool CheckIfHigher(this int number, int comparisonNumber)
        {
            if (number < comparisonNumber)
            { return false; }
            else 
                return true;
        }

        static public string CreateEmailAdress(this string fullName, int yearOfBirth, string domain) 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        return fullName.Replace(" ", "")+ yearOfBirth +"@"+ domain;
        }

    }
}
