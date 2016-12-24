using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal interface UsefulActivity
    {
        void learnMatan();
        void writeLabs();
        void elevateMind();

    }


    internal interface Relax
    {
        void degrade();
        void doNothing();
    }

    internal interface childActivities
    {
        void playingInYard();
        void beIll();
    }
}