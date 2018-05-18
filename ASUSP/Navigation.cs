using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUSP
{
    class Navigation
    {
        public static List<MapSquare> iceBricks = new List<MapSquare>();
        public static List<MapSquare> specialBricks = new List<MapSquare>();
        public static List<MapSquare> commonBricks = new List<MapSquare>();

        public static Queue<Transaction> transactionOrder = new Queue<Transaction>();
    }
}
