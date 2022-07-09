using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game._002
{
    public class GameRand 
    {
        public static int Next()
        {
            Random r = new Random();
            return r.Next();
        }
    }
}
