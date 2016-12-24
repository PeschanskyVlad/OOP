using System;
using System.Collections;
using System.Collections.Generic;


/**
 * На этом участке кода было применено горизонтальное и вертикальное форматирование согласно правилам чистого кода,
 * что бы повысить его читабельность.
 * */

namespace Lab1
{
    enum Days { Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun };

    [Serializable]
    public class VerkhovnaRada : IEnumerable, IEnumerator
    {

        private string country;
        private int count;


        private int currentDay;


        /**
         * По правилам чистого кода имена должны соолветсвовать намерениям програмиста,
         * по этому переменная int temp = 0; которая отвечала за текущее количество олигархов соответствующе переименована.
         * */
        int CurrentCountOfOligharchs = 0;
        private const int MaxCountOfOligarchs = 10;
        private Employee[] oligarchs = new Employee[MaxCountOfOligarchs];
        private int oligarchsIndex = -1;






        List<Employee> ServantsOfPeople = new List<Employee>();
        private List<Spy<Employee>> Insiders = new List<Spy<Employee>>();



        public VerkhovnaRada(string _country, int day)
        {
            this.country = _country;
            count = 0;
            currentDay = Math.Abs(day % 8);
        }



        public bool AddOligarch(Employee oligarch)
        {
            /**
             * Согласно правилам чистого кода непонятное число 10 было заменено константой.
             * */
            if (CurrentCountOfOligharchs < MaxCountOfOligarchs)
            {
                oligarchs[CurrentCountOfOligharchs] = oligarch;
                CurrentCountOfOligharchs++;
                return true;
            }
            else
            {
                Console.WriteLine("No more!");
                return false;
            }
        }

        public void showDay()
        {
            Console.WriteLine("Current day = " + currentDay);
        }

        public void changeDay()
        {
            currentDay = Math.Abs(currentDay++ % 8);
        }

        public bool work()
        {
            if (currentDay == (int)Days.Sun || currentDay == (int)Days.Sat)
            {

                Console.WriteLine("Nobody works on weekends!");
                return false;

            }
            else
            {
                Console.WriteLine("Hard working!");
                return true;
            }

        }


        /**
         * Так как названия классов должны представлять собой глагольные словосочитания,
         * то метод newSFBAgent был переименован в AddSpy.
         **/


         /**
          * Тут стоял старый коментарий который указывал на то, что Агентов фсб(шпионов) может быть не больше 50,
          * так как на тот момент их количество не зависело от общего, что теперь будет вводить в заблуждение. 
          * Согласно правилам чистого кода старые комментарии должны удаляться или обновляться.
          * */   



        public bool AddSpy(Spy<Employee> agent)
        {
            if (count < 450)
            {
                Insiders.Add(agent);
                count++;
                return true;
            }
            else
            {
                Console.WriteLine("Need trimming!");
                return false;
            }
        }




        public bool addServant(Employee Employee)
        {
            if (count < 450)
            {
                ServantsOfPeople.Add(Employee);
                count++;
                return true;
            }
            else
            {
                Console.WriteLine("Need trimming!");
                return false;
            }

        }

        //По правилу рефакторинга про дублирование кода две предыдущие функции с почти аналогичным кодом были обьеденены в одну.

        public bool univesalAdd(object obj)
        {
            Console.WriteLine("Type = "+obj.GetType());

            if (count < 450)
            {

                if (obj is Employee)
                {
                    ServantsOfPeople.Add((Employee)obj);
                }
                else
                {

                    if (obj is Spy<Employee>)
                    {
                        Insiders.Add((Spy<Employee>)obj);

                    }else
                    {
                        return false;
                    }
                }
                 count++;
                return true;
            }
            else
            {
                Console.WriteLine("Need trimming!");
                return false;
            }

        }


        //Согласно правилам про дублирование кода и расходящиеся модификации проверка на null была вынесена отдельно
        public void showServants()
        {

            foreach (Employee servant in ServantsOfPeople)
            {

                if (isNull(servant))
                {
                    servant.showPersonalData();
                }
            }

        }

        public void sortServantsByAge()
        {
            ServantsOfPeople.Sort();
        }


        /**
         * Согласно правилам чистого кода функция или метод не должны делать никаких побочных действий.
         * Потому из функции был убран вывод на экран:
         *  Console.WriteLine("Where you dug it?");
         * 
         * */

        private Employee GetServantByName(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (ServantsOfPeople[i].name == Name)
                {
                    return ServantsOfPeople[i];
                }
            }         
            return null;
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

        public bool isNull(object obj)
        {
            if(obj == null)
            {
                return true;
            }
            return false;
        }


    }

}