using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Soldado:Tropa
    {
        /*Esta classe � a implementa��o mais b�sica de tropa, com a taque e defesa unit�rios
         Criado por Eduardo em 16/06/2019*/
        public Soldado(Player p){
            atk = 1;
            def = 1;
            controller = p;
        }
    }
}
