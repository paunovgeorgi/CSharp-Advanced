using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
   public static class DateModifier
    {
        public static int GetDifference(string dateOne, string dateTwo)
        {
           // int[] firstDateSplit = dateOne.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           // int firstYear = firstDateSplit[0];
           // int firstMonth = firstDateSplit[1];
           // int firstDay = firstDateSplit[2];

           // int[] secondDateSplit = dateTwo.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           // int secondYear = secondDateSplit[0];
           // int secondMonth = secondDateSplit[1];
           // int secondDay = secondDateSplit[2];

           //DateTime first = new(firstYear, firstMonth, firstDay);
           //DateTime second = new(secondYear, secondMonth, secondDay);

           DateTime startDate = DateTime.Parse(dateOne);
           DateTime endDate = DateTime.Parse(dateTwo);


           TimeSpan difference = endDate - startDate;

         return  Math.Abs(difference.Days);
        }
    }
}
