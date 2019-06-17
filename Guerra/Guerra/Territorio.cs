//+src=Map.cs
//+src=Player.cs
//+src=Soldado.cs
//+src=Tropa.cs
//+src=Program.cs
//+src=
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Territorio
    {
        /*Esta classe define o comportamento e atributos dos territ�rios.
         Criado por Eduardo em 16/06/2019*/
        public readonly string nome;
        //Inicialmente todo territ�rio � controlado pelo jogador padr�o nulo
        private Player controlador = Program.PLAYER_NULL;
        //Identifica��o que serve para simplificar as conex�es
        public readonly int id;
        //Visto que h� no m�ximo 8 c�lulas ao redor de uma c�lula qualquer numa matriz, o n�mero m�ximo de conex�es � 8
        private int[] conexoes = new int[8];
        //Implementa��o atual de tropas, com limite de 100 em um �nico territ�rio. Sujeito a altera��es
        private Tropa[] tropas = new Tropa[100];
        //Contadores
        private int i,t = 0;
        public Territorio(string nome, int id){
            this.nome = nome;
            this.id = id;
            //Inicia todas as conex�es como -1 (valor padr�o para aus�ncia de conex�o)
            foreach(int t in conexoes){
                conexoes[t]=-1;
            }
        }
        //Atualiza a quem este territ�rio pertence
        public void updateControlador(){
            controlador = tropas[0].getController();
        }
        public Player getControlador(){
            return controlador;
        }
        //Cria uma conex�o com o territ�rio de �ndice id
        public void addConnection(int id){
            //Garante que o id de conex�o � diferente do id do pr�prio territ�rio
            if (this.id != id)
            {
                conexoes[i] = id;
                i++;
            }
        }
        //Remove a conex�o especificada
        public void removeConnection(int id){
            int c = 0;
            while(id!=conexoes[c]){
                if(c<8){
                    c++;
                }else{
                    break;
                }
            }
            conexoes[c] = -1;
        }
        //Adiciona uma tropa do tipo Soldado ao territ�rio
        public void addSoldado(Player p){
            tropas[t]= new Soldado(p);
            t++;
        }
        //Remove uma tropa do tipo soldado do territ�rio
        public void removeSoldado(){
            if(t!=0){
                tropas[t]= null;
                t--;
            }
        }
        //Retorna a quantidade de tropas no territ�rio
        public int troops(){
            return t;
        }
    }
}
