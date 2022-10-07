using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_time_conversion
{
    class Program
    {
        // solution 1
        public static string timeConversion(string s)
        {
            // 07:05:45PM 
            // Constraints -> all input times are valid.
            string hour = s.Substring(0, 2);
            string minute = s.Substring(3, 2);
            string seconds = s.Substring(6, 2);
            int nx = int.Parse(s.Substring(0, 2));
            if (s[8] == 'P'){
                if (nx < 12){
                    nx += 12;
                    hour = nx.ToString();
                }
            }
            else {
                    if (nx == 12){
                        hour = "00";
                    }
            }
            //Console.WriteLine(hour + ":"+minute  + ":" + seconds);
            return hour + ":" + minute + ":" + seconds;
        }

        // solution 2
        public static string timeConversion2(string s)
        {
            // you should add -> using System.Globalization;
            var dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
            return $"{dt:HH:mm:ss}";
        }


    }
}
