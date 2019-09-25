using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssign3
{
    class sudo
    {
        public static void Main(string[] args)
        {

            // creating object of derived class 
            Athlete g = new Athlete();
            Person h = new Person();
            
            // calling the method of base class  
            // using the derived class object 
            g.stf();
        }
    }
}
