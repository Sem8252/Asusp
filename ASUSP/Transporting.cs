using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASUSP
{
    //enum TransporterStatus { Waiting, Working, OnStation}

    class Transporter
    {
        int x;
        int y;
        bool isWaiting;
    }

    class Map
    {
        static string path = "Map.csv";
        static int length = 10;
        static int weight = 10;
        public static MapSquare[,] MapFromCSV()
        {
            MapSquare[,] map = new MapSquare[length, weight];
            var csv = File.ReadAllLines(path);
            for (int i = 0; i < weight; i++)
            {
                var line = csv[i].Split(',');
                for (int j = 0; j < length; j++)
                {
                    var cell = line[j].Split(';');
                    int x = Convert.ToInt32(cell[0]);
                    int y = Convert.ToInt32(cell[1]);
                    bool patency = Convert.ToBoolean(cell[2]);
                    map[i, j] = new MapSquare(x, y, patency);
                }
            }
            return map;
        }

        public static void MapToCSV(MapSquare[,] map)
        {
            List<string> lines = new List<string>();
            for (int j = 0; j < length; j++) 
            {
                string[] newString = new string[weight];
                for (int i = 0; i < weight; i++) 
                {
                    newString[i] = map[i, j].toCSVString();
                }
                string convertedString = newString[0] +","+ newString[1] + "," + newString[2] + "," + newString[3] + "," + 
                    newString[4] + "," + newString[5] + "," + newString[6] + "," + newString[7] + "," + newString[8] + "," + newString[9];
                lines.Add(convertedString);
            }
            File.WriteAllLines(path, lines);
        }
    }

    class MapSquare
    {
        public int x;
        public int y;
        public bool isPatency;
        public string toCSVString()
        {
            string output = this.x.ToString() + ";" + this.y.ToString() + ";" + this.isPatency.ToString();
            return output;
        }
        public MapSquare(int x, int y, bool patency)
        {
            this.x = x;
            this.y = y;
            this.isPatency = patency;
        }
    }
}
