using System;
namespace Lab1
{
    public class FSBAgent<T> where T : Citizen
    {

        public void preparationsForTheVote(AbstractHuman human)
        {
            Votes.Voting += human.toVote;
        }


    }

}