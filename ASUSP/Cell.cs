using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUSP
{
    enum CellType { Standart, Freeze, Special}

    enum CellSize { Small, Medium, Large}

    class Cell
    {
        public int type;
        public int size;
        public string ID;

        public Cell(string CellToStringObject)
        {
            var line = CellToStringObject.Split(';');
            this.type = Convert.ToInt32(line[0]);
            this.size = Convert.ToInt32(line[1]);
            this.ID = line[2];
        }

        public Cell()
        { }

        public Cell(int type, int size, string id)
        {
            this.type = type;
            this.size = size;
            this.ID = id;
        }

        public string ConvertToString()
        {
            var Type = Convert.ToString(this.type);
            var Size = Convert.ToString(this.size);
            var Id = this.ID;
            var line = Type+";"+Size+";"+Id;
            return line;
        }
    }
}
