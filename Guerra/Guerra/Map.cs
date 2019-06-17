using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Guerra
{

    public class Map 
    {
        private Territorio[,] map;
        public Map(int width, int height){
            map = new Territorio[width,height];
        }
        
    }
}
