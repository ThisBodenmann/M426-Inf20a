using System;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string result = "";

            if (input % 3 == 0) { result = "Foo"; }
            if (Convert.ToString(input).Contains("3")) { result += "Foo"; }
            if (input % 5 == 0) { result += "Bar"; }
            if (Convert.ToString(input).Contains("5")) { result += "Bar"; }
            if (input % 7 == 0) { result += "Qix"; }
            if (Convert.ToString(input).Contains("7")) { result += "Qix"; }



            if (result == "") { return Convert.ToString(input); }
            return result;
        }
    }
}