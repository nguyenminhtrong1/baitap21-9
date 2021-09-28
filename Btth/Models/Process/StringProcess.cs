using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Btth.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string id) 
        {
            string numPart, strPart, newKey = "", newNumPart="";
            int intNumber;

            numPart = Regex.Match(id, @"\d+").Value;

            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0;i < numPart.Length - intNumber.ToString().Length; i++) 
            {
                newNumPart += intNumber;
            }
            newNumPart += intNumber;
            strPart = numPart = Regex.Match(id, @"\d+").Value;
            newKey = strPart + newNumPart;

            return newKey;
        }
    }
}