using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    
        class Oligharks : IEnumerable, IEnumerator
    {
        private const int countOfOligarchs = 10;
        private int currentCountOfOligharcs = 0;
        private Employee[] oligarchs = new Employee[countOfOligarchs];
        private int oligarchsIndex = -1;


        public Employee this[string Name]
         {
            get
            {
                for (int i = 0; i < countOfOligarchs; i++)
                {
                    if (oligarchs[i].name == Name)
                    {
                        return oligarchs[i];
                    }
                }

                Console.WriteLine("Where you dug it?");
                return null;
            }
        }

       

        public bool AddOligarch(Employee oligarch)
        {
            if (currentCountOfOligharcs < 10)
            {
                oligarchs[currentCountOfOligharcs] = oligarch;
                currentCountOfOligharcs++;
                return true;
            }
            else
            {
                Console.WriteLine("No more!");
                return false;
            }


        }


        public IEnumerator GetEnumerator()
        {
            return this;
        }




        public bool MoveNext()
        {
            if (oligarchsIndex == oligarchs.Length - 1 || oligarchs[oligarchsIndex + 1] == null)
            {
                Reset();
                return false;
            }

            oligarchsIndex++;
            return true;
        }




        public void Reset()
        {
            oligarchsIndex = -1;
        }

        public object Current
        {
            get
            {
                return oligarchs[oligarchsIndex];
            }
        }


    }
}
