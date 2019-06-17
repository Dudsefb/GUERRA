using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Player 
    {
        private Territorio basee;
        public string Nome{get;set;}
        public Player(string name){
            Nome = name;
        }
        public void setBase(ref Territorio t){
            basee = t;
            basee.addSoldado(this);
            basee.updateControlador();
        }
    }
}
