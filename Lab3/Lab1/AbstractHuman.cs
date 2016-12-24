using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[Serializable]
abstract public class AbstractHuman
{
    public int age;
    public double mass;

    public string name;

    abstract public void eat();
    abstract public void sleep();
    abstract public void toVote();
  
}