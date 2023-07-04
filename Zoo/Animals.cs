using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    //Abstract class animals 
    public abstract class Animals
    {
        
        public abstract string Name { get; set; }
        public abstract int age { get; set; }

        //Abstract methods should be overridden 
        public abstract void Eat();
        public abstract string Type();

        //Virtual methods should be overridden
        public virtual string Sound()
        {
            return "The animals makes sounds";
        }
        public virtual string sleep()
        {
            return "The animal is sleeping";
        }
       
        
    }
}
