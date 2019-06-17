using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Soldado:Tropa
    {
        /*Esta classe é a implementação mais básica de tropa, com a taque e defesa unitários
         Criado por Eduardo em 16/06/2019*/
        public Soldado(Player p){
            atk = 1;
            def = 1;
            controller = p;
        }
    }
}
