using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public abstract class Tropa 
    {
        protected int atk, def;
        protected Player controller;
        public Player getController(){
            return controller;
        }
        
    }
}
