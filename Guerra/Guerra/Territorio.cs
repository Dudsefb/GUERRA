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
        public readonly string nome;
        private Player controlador = Program.PLAYER_NULL;
        public readonly int id;
        private int[] conexoes = new int[8];
        private Tropa[] tropas = new Tropa[100];
        private int i,t = 0;
        public Territorio(string nome, int id){
            this.nome = nome;
            this.id = id;
            foreach(int t in conexoes){
                conexoes[t]=-1;
            }
        }
        public void updateControlador(){
            controlador = tropas[0].getController();
        }
        public Player getControlador(){
            return controlador;
        }
        public void addConnection(int id){
            conexoes[i] = id;
            i++;
        }
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
        public void addSoldado(Player p){
            tropas[t]= new Soldado(p);
            t++;
        }
        public void removeSoldado(){
            if(t!=0){
                tropas[t]= null;
                t--;
            }
        }
        public int troops(){
            return 0;
        }
    }
}
