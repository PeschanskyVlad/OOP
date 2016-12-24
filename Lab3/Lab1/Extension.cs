using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public static class Extension
    {

         static int someCount(this Oligharks rada, string sex)
        {
            int counter = 0;

            foreach (Employee oligharch in rada)
            {

                if (oligharch.getSex() == sex)
                {
                    counter++;


                }

            }

            Console.WriteLine("There are " + counter+" "+sex+" oligharchs in goverment.");

            return counter;
        }

    }
}
