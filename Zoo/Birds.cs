using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //abstrct class birds inherits class animals 
    public abstract class Birds:Animals
    {
        //Override the method sleep from the class animals
        public override void sleep()
        {
            base.sleep();
        }
        //Abstract method 
        public abstract string Fly();
    }
}
