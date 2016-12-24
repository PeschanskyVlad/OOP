using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
class Underage : Citizen, childActivities
{

    private List<string> toys = new List<string>();

    
    public Underage(string name, int age, double mass, string sex) : base(name, age, mass, sex)
    {

    }

    public void Cry()
    {
        Console.WriteLine("Yaaaaaaaaa...");
    }

    public void addToy(string s)
    {
        toys.Add(s);
    }

    public void showToys()
    {
        foreach (var toy in toys)
        {
            Console.Write(toy + " ");
        }
    }


    public void AnnoyParents()
    {
        Console.WriteLine("Boom! Ehehehe...");
    }

    public void PlayUnderTheTable()
    {
        Console.WriteLine("Bzzzz...");
    }

    public void beIll()
    {
        Console.WriteLine("Go to hospital.");
    }
    public void playingInYard()
    {
        Console.WriteLine("=_=");
    }

}

