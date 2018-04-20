using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUSP
{
    enum ProductTypes { Common, Tech, Food}

    class Transaction
    {
        int ID { get; set; }
        DateTime startDate { get; set; }
        DateTime expiryDate { get; set; }
        int productType { get; set; }
        int productCode { get; set; }
        string country { get; set; }
        string city { get; set; }
        string firm { get; set; }
        Cell cell { get; set; }
        public Transaction(int startYear, int startMonth, int startDate, int expityYear, int expityMonth, int expityDate, 
            ProductTypes type, int code, string country, string city, string firm, Cell cell)
        {
            this.startDate = new DateTime(startYear, startMonth, startDate);
            this.expiryDate = new DateTime(expityYear, expityMonth, expityDate);
            this.productType = (int)type;
            this.productCode = code;
            this.country = country;
            this.city = city;
            this.firm = firm;
            this.cell = cell;
            //this.ID = GetID();
        }

        private int GetID()
        {
            return 0;
        }
    }
}
