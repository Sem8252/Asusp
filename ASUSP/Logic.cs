using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUSP
{
    class Logic
    {
        public static Transaction AddFromScreen(string StartDate, string ExpDate, int Type, string Code,
            string Country, string City, string Firm, int CellType)
        {
            Transaction newTransaction = new Transaction();
            newTransaction.startDate = Convert.ToDateTime(StartDate);
            newTransaction.expiryDate = Convert.ToDateTime(ExpDate);
            newTransaction.productType = Type;
            newTransaction.productCode = Convert.ToInt32(Code);
            newTransaction.country = Country;
            newTransaction.city = City;
            newTransaction.firm = Firm;
            newTransaction.cell = new Cell(Type, 1, "Test"); //ИСПРАВИТЬ
            return newTransaction;
        }

        public static List<Transaction> Data { get; set; }
        public static int StartLine { get; set; }
    }
}
