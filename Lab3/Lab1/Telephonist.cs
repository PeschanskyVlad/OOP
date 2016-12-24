using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
class Telephonist : Employee
{
    private Telephonist(string name, int age, double mass, string sex) : base(name, age, mass, sex) //This class has private contuctor because job "Telephonist" is dead, and we can`t create new telephonist now.
    {

    }

    public Telephonist newTelephonist(int year, int age, double mass, string sex)
    {
        if (year > 2000)
        {
            Telephonist human = new Telephonist(name,age, mass, sex);
            return human;
        }
        return null;
    }


}

