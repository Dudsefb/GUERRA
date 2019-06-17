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
        private static Territorio t = new Territorio("Argelia", 0);
        public static Player PLAYER_NULL = new Player("Niguém");
        private static Player p = new Player("Eduardo");
        private static Map m = new Map(8, 14);
        public static void Main()
        {
            Console.WriteLine("Programa iniciado!");
            p.setBase(ref t);
            Console.WriteLine("Territorio {0} é controlado por {1}", t.nome, t.getControlador().Nome);
        }
    }
}
