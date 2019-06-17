using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Soldado:Tropa
    {
        public Soldado(Player p){
            atk = 1;
            def = 1;
            controller = p;
        }
    }
}
