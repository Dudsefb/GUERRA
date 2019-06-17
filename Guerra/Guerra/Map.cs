using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Map 
    {
        /*Esta classe é um array de territórios organizados. Espaços vazios serão territórios nulos.
         * Ela é capaz de conectar os territórios fronteiriços, ligações excepcionais serão implementadas futuramente
         * Na versão final ela também possuirá a capacidade de gerar mapas aleatórios
         Criado por Eduardo em 16/06/2019*/
        private Territorio[,] map;
        //Dimensões da matriz
        private int w, h;
        public Map(int width, int height, bool random = false){
            map = new Territorio[width,height];
            w = width;
            h = height;
            if (random)
            {
                //futuro método para gerar mapas aleatórios
            }
        }
        //Gera as conexões.
        public void generateConnections()
        {
            //Varia i
            for(int i = 0; i < w; i++)
            {
                //Varia j
                for(int j = 0; j < h; j++)
                {
                    //se a célula em questão é nula, ele avança para a próxima.
                    if (map[i, j] != null)
                    {
                        //Testa se a célula está na borda i máximo
                        if (i != w - 1)
                        {
                            //Se a célula imediatamente à frente não é nula, a conexão é criada em ambos os territórios
                            if (map[i + 1, j] != null)
                            {
                                map[i, j].addConnection(map[i + 1, j].id);
                                map[i + 1, j].addConnection(map[i, j].id);
                            }
                        }
                        //Testa se a célula está em j máximo
                        if (j != h - 1)
                        {
                            //Testa se a célula está na borda i máximo
                            if (i != w - 1)
                            {
                                //Se a célula na diagonal abaixo e à frente não é nula, a conexão é criada
                                if (map[i + 1, j + 1] != null)
                                {
                                    map[i, j].addConnection(map[i + 1, j + 1].id);
                                    map[i + 1, j + 1].addConnection(map[i, j].id);
                                }
                            }
                            //Se a célula abaixo não é nula, a conexão é criada
                            if (map[i, j + 1] != null)
                            {
                                map[i, j].addConnection(map[i, j + 1].id);
                                map[i, j + 1].addConnection(map[i, j].id);
                            }
                            //Testa se a célula esta na borda 0 em i
                            if (i != w) {
                                //Se a célula na diagonal abaixo atrás não é nula, a conexão é criada.
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
