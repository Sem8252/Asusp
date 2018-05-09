using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace ASUSP
{
    enum ProductTypes { Common, Tech, Food}

    class Transaction
    {
        public int ID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime expiryDate { get; set; }
        public int productType { get; set; }
        public int productCode { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string firm { get; set; }
        public Cell cell { get; set; }
        public bool status = false;
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
        public Transaction()
        {

        }

        private int GetID()
        {
            return 0;
        }
    }
}
