using System;
using System.Runtime.Serialization;

[Serializable]
internal class MyException : Exception
{
    private int ageV;
    public int AgeV { get { return ageV; } }

    public MyException(int age, string message) : base(message)
    {
        ageV = age;
    }
}