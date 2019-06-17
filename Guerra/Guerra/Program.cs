//+src=Tropa.cs
//+src=Territorio.cs
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public static class Program
    {
        /*Esta classe instancia objetos de teste. Será modificada na versão final.
         Criado por Eduardo em 16/06/2019*/
        private static Territorio t = new Territorio("Argelia", 0);
        //Cria um player padrão utilizado na ausência de jogadores válidos
        public static Player PLAYER_NULL = new Player("Niguém");
        private static Player p = new Player("Eduardo");
        private static Map m = new Map(3, 3);
        public static void Main()
        {
            //Printa uma mensagem de início
            Console.WriteLine("Programa iniciado!");
            p.setBase(ref t);
            Console.WriteLine("Territorio {0} é controlado por {1}", t.nome, t.getControlador().Nome);
        }
    }
}
