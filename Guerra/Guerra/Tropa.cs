using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public abstract class Tropa 
    {
        /*Esta classe é uma definição abstrata dos atributos que todos os tipos de tropa devem ter
         Criado por Eduardo em 16/06/2019*/
        //Pontos de ataque e defesa
        protected int atk, def;
        //A quem a tropa pertence
        protected Player controller;
        public Player getController(){
            return controller;
        }
        
    }
}
