using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // call the salam to console method
            SalamToConsole();
        }

        /*
         * @description This is my Salam Method
         * @method SalamToConsole 
         * @return {string} SalamString
         */

        public static string SalamToConsole()
        {
            string SalamString = "Assalamu alaikum";
            Console.WriteLine(SalamString);
            return SalamString;
        }
    }
}
