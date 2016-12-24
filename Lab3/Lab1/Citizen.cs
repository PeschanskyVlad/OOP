using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab1
{

    [Serializable]
    public class Citizen : AbstractHuman
    {


       private string[] citizenships = new string[3];

        protected string sex;

        //action Func
        Func<string,string> nowIsTheTime = justDoIt;
        static Action<string> message = delegate (string s) { Console.WriteLine(s); };

        public Citizen()
        {

        }






        private double NumberOfFingers;

        public double NumberOfLimbs
        {
            get { return NumberOfFingers / 4; }
            set {

                if (value != 4)
                {
                    Console.WriteLine("This is not a human!");
                }
                else
                {
                    NumberOfFingers = value * 4;
                }
            }
        }





        

        public Citizen(string _name, int _age, double _mass, string sex)
        {
            name = _name;
            age = _age;
            mass = _mass;
            this.sex = sex;
            for(int i = 0; i < citizenships.Length; i++) {
                citizenships[i] = "nan";
            }
        }





        /*static void message(string s)
        {
            Console.WriteLine(s);
        }*/

        

        static string justDoIt(string s)
        {
            message(s + " vote for United Russia.");

            return "OK";
        }



        public bool addCitizenship(string s)
        {
            for (int i = 0; i < citizenships.Length; i++)
            {
                if(citizenships[i] == "nan")
                {
                    citizenships[i] = s;
                    return true;
                }
            }
            return false;
        }



        public void showCitizenship()
        {
            for (int i = 0; i < citizenships.Length; i++)
            {
                Console.WriteLine(citizenships[i]);
            }
        }




        public override void eat()
        {
            Console.WriteLine("Omnomnom...");
        }

        public override void toVote()
        {
            nowIsTheTime(name);
        }


        public virtual void live()
        {
            Console.WriteLine("Still Ative.");
        }

        public override void sleep()
        {
            Console.WriteLine("Zzz..");
        }

       

        public int setAge(int newAge)
        {

            age = newAge;
            if (age < 0)
            {
                throw new MyException(age, "Invalide age ");
            }
            return age;
        }

        public int getAge()
        {
            return age;
        }

        public String getSex()
        {
            return sex;
        }


        public double getMass()
        {
            return mass;
        }

        public void showPersonalData()
        {
            Console.WriteLine("Name: " + this.name + ", Age: " + this.age + ", Mass: " + this.mass + ";");
        }

        /*private int increase(int i)
        {
            return i++;
        }*/

    }

}