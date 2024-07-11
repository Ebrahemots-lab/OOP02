using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class HiringDate
    {
        public HiringDate(int day, int month, int years)
        {
            Day = day;
            Month = month;
            Years = years;
        }

        public static int CompareYear(HiringDate date1, HiringDate date2)
        {
            return date1.Years.CompareTo(date2.Years); //From Internet --
        }

        public int Day { get; }
        public int Month { get; }
        public int Years { get; }

        public override string ToString()
        {
            return $"{Day} - {Month} - {Years}";
        }


      



    }
}
