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
        int type;
        int size;
        string ID;
    }
}
