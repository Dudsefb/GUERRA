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
        /*Esta classe define o comportamento e atributos dos territórios.
         Criado por Eduardo em 16/06/2019*/
        public readonly string nome;
        //Inicialmente todo território é controlado pelo jogador padrão nulo
        private Player controlador = Program.PLAYER_NULL;
        //Identificação que serve para simplificar as conexões
        public readonly int id;
        //Visto que há no máximo 8 células ao redor de uma célula qualquer numa matriz, o número máximo de conexões é 8
        private int[] conexoes = new int[8];
        //Implementação atual de tropas, com limite de 100 em um único território. Sujeito a alterações
        private Tropa[] tropas = new Tropa[100];
        //Contadores
        private int i,t = 0;
        public Territorio(string nome, int id){
            this.nome = nome;
            this.id = id;
            //Inicia todas as conexões como -1 (valor padrão para ausência de conexão)
            foreach(int t in conexoes){
                conexoes[t]=-1;
            }
        }
        //Atualiza a quem este território pertence
        public void updateControlador(){
            controlador = tropas[0].getController();
        }
        public Player getControlador(){
            return controlador;
        }
        //Cria uma conexão com o território de índice id
        public void addConnection(int id){
            //Garante que o id de conexão é diferente do id do próprio território
            if (this.id != id)
            {
                conexoes[i] = id;
                i++;
            }
        }
        //Remove a conexão especificada
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
        //Adiciona uma tropa do tipo Soldado ao território
        public void addSoldado(Player p){
            tropas[t]= new Soldado(p);
            t++;
        }
        //Remove uma tropa do tipo soldado do território
        public void removeSoldado(){
            if(t!=0){
                tropas[t]= null;
                t--;
            }
        }
        //Retorna a quantidade de tropas no território
        public int troops(){
            return t;
        }
    }
}
