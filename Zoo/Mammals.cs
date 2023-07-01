using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Abstract class mammals inherits from Animals 
    public abstract class Mammals : Animals
    {

        public override void sleep()
        {
            base.sleep();
        }
        public abstract void Birth();
    }
}
