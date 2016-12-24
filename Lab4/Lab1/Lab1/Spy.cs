using Lab1;
using System;

namespace Lab1
{
    [Serializable]
    /*
     * По правилам чистого кода нужно избегать остроумия,
     *  по этому класс FSBAgent был переименован в Spy.
    */
    public class Spy<T> where T : AbstractHuman , IDisposable
    {
        private T val;
       
        public Spy(T human)
        {
            val = human;
        }


        public T getValue()
        {
            return val;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}