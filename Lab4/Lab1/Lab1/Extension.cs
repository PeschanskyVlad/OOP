using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public static class Extension
    {

        //Тут удален комментарий обьясняющий что делает этот метод, 
        //ибо по правилам рефакторинга после переименования метод достаточно хорошо описывает происходимые в нем действия.

        public static int countHumansByGivenSex(this VerkhovnaRada rada, string sex)
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
