using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
     class ClassVotes
    {



        public delegate void Insight(AbstractHuman Sender, ClassVotes Votes);



        public delegate void EventOfCentury();

        public event EventOfCentury Voting;

       public delegate void allert();

       

        allert message = delegate
        {
            Console.WriteLine("Vote time!");
        };



        public void IsItTime()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    message();

                    Voting?.Invoke();
                    break;
                }
            }
        }



        //lambda - вираз

       public Insight rightWay = (AbstractHuman Sender, ClassVotes Votes) =>
        {

            Votes.Voting += Sender.toVote;
        };



    }
}