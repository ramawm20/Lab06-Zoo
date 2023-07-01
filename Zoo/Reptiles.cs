using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Reptiles:Animals
    {
        public override void sleep()
        {
            base.sleep();
        }
        public abstract void PutEggs();
    }
}
