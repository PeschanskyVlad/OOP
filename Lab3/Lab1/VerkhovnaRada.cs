using Lab1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab1
{
    enum Days {  Mon = 1 , Tue, Wed, Thu, Fri, Sat, Sun };

    [Serializable]
    public class VerchovnaRada 
    {

        private string country;
        private int count;

       
        private int currentDay;



        //int temp = 0;
       /* private const int countOfOligarchs = 10;
        private Employee[] oligarchs = new Employee[countOfOligarchs];
        private int oligarchsIndex = -1;*/


       



        List<Employee> ServantsOfPeople = new List<Employee>();

        private List<FSBAgent<Employee>> Insider = new List<FSBAgent<Employee>>();



        public VerchovnaRada(string _country, int day){
            this.country = _country;
            count = 0;
            currentDay = Math.Abs(day % 8);
        }

       

        /*public bool AddOligarch(Employee oligarch)
        {
            if (temp < 10)
            {
                oligarchs[temp] = oligarch;
                temp++;
                return true;
            }
            else
            {
                Console.WriteLine("No more!");
                return false;
            }


        }*/
        public void showDay()
        {
            Console.WriteLine("Current day = "+currentDay);
        }

        public void changeDay()
        {
            currentDay = Math.Abs(currentDay++ % 8);
        }

        public bool work()
        {
            

            if (currentDay == (int)Days.Sun|| currentDay == (int)Days.Sat) {

                Console.WriteLine("Nobody works on weekends!");
                return false;

            }else{
                Console.WriteLine("Hard working!");
                return true;
            }

        }

      

        public bool AddFSBAgent(FSBAgent<Employee> agent)
        {
            if (count < 450)
            {
                Insider.Add(agent);
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
                if (count<450)
                {
                ServantsOfPeople.Add(Employee);
                count++;
                 return true;
                }
            else{
                Console.WriteLine("Need trimming!");
                return false;
            }   
           
        }

        public void showServants()
        {
           
            foreach (Employee servant in ServantsOfPeople)
            {
               
                if (servant != null){
                    servant.showPersonalData();
                }         
            }

        }
        
        public void sortServantsByAge()
        {
            ServantsOfPeople.Sort();
        }
    

        private Employee GetServantByName(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (ServantsOfPeople[i].name == Name)
                {
                    return ServantsOfPeople[i];
                }
            }

            Console.WriteLine("Where you dug it?");
            return null;
        }

       /* public IEnumerator GetEnumerator()
        {
            return this;
        }



        public bool MoveNext()
        {
            if (oligarchsIndex == oligarchs.Length - 1||oligarchs[oligarchsIndex+1] == null)
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
        */
        
    }



    

}