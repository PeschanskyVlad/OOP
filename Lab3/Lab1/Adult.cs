using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Adult : Citizen, Relax
{

    public Adult()
    {

    }

    public Adult(string name,int age, double mass, String sex) : base(name,age , mass, sex)
    {

    }

   

    public override void live()
    {
        Console.WriteLine("Another day...");
    }

    

    public void degrade()
    {
        Console.WriteLine("Still degrade...");
    }

    public void doNothing()
    {

    }



}

