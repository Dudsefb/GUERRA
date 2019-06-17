using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Map 
    {
        /*Esta classe � um array de territ�rios organizados. Espa�os vazios ser�o territ�rios nulos.
         * Ela � capaz de conectar os territ�rios fronteiri�os, liga��es excepcionais ser�o implementadas futuramente
         * Na vers�o final ela tamb�m possuir� a capacidade de gerar mapas aleat�rios
         Criado por Eduardo em 16/06/2019*/
        private Territorio[,] map;
        //Dimens�es da matriz
        private int w, h;
        public Map(int width, int height, bool random = false){
            map = new Territorio[width,height];
            w = width;
            h = height;
            if (random)
            {
                //futuro m�todo para gerar mapas aleat�rios
            }
        }
        //Gera as conex�es.
        public void generateConnections()
        {
            //Varia i
            for(int i = 0; i < w; i++)
            {
                //Varia j
                for(int j = 0; j < h; j++)
                {
                    //se a c�lula em quest�o � nula, ele avan�a para a pr�xima.
                    if (map[i, j] != null)
                    {
                        //Testa se a c�lula est� na borda i m�ximo
                        if (i != w - 1)
                        {
                            //Se a c�lula imediatamente � frente n�o � nula, a conex�o � criada em ambos os territ�rios
                            if (map[i + 1, j] != null)
                            {
                                map[i, j].addConnection(map[i + 1, j].id);
                                map[i + 1, j].addConnection(map[i, j].id);
                            }
                        }
                        //Testa se a c�lula est� em j m�ximo
                        if (j != h - 1)
                        {
                            //Testa se a c�lula est� na borda i m�ximo
                            if (i != w - 1)
                            {
                                //Se a c�lula na diagonal abaixo e � frente n�o � nula, a conex�o � criada
                                if (map[i + 1, j + 1] != null)
                                {
                                    map[i, j].addConnection(map[i + 1, j + 1].id);
                                    map[i + 1, j + 1].addConnection(map[i, j].id);
                                }
                            }
                            //Se a c�lula abaixo n�o � nula, a conex�o � criada
                            if (map[i, j + 1] != null)
                            {
                                map[i, j].addConnection(map[i, j + 1].id);
                                map[i, j + 1].addConnection(map[i, j].id);
                            }
                            //Testa se a c�lula esta na borda 0 em i
                            if (i != w) {
                                //Se a c�lula na diagonal abaixo atr�s n�o � nula, a conex�o � criada.
                                if (map[i - 1, j + 1] != null)
                                {
                                    map[i, j].addConnection(map[i - 1, j + 1].id);
                                    map[i - 1, j + 1].addConnection(map[i + 1, j + 1].id);
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        
    }
}
