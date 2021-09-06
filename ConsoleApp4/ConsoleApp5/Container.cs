using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Container
    {
        public int WeightOfAllBoxes
        {
            get
            {
                return WeightOfAllBoxes;
            }
            set
            {
                Random rand = new Random();
                WeightOfAllBoxes = rand.Next(50,1001);
            }
        }
        public Container(int numOfBoxes)
        {
            Box[] boxesOnCont = new Box[numOfBoxes];
            for(int i =0; i < numOfBoxes; i++)
            {

            }
        }
    }
}
