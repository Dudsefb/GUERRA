using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Player 
    {
        /*Esta classe define os atributos dos jogadores
         */
        //Define o território que será base do jogador
        private Territorio basee;
        public string Nome{get;set;}
        public Player(string name){
            Nome = name;
        }
        //Altera a base do jogador, adiciona um soldado a ela e atualiza o controlador do território
        public void setBase(ref Territorio t){
            basee = t;
            basee.addSoldado(this);
            basee.updateControlador();
        }
    }
}
