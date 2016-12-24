using Lab1;
using System;

namespace Lab1
{
    [Serializable]
    public class FSBAgent<T> where T : AbstractHuman 
    {
        private T val;
       
        public FSBAgent(T human)
        {
            val = human;
        }


        public T getValue()
        {
            return val;
        }
    }
}