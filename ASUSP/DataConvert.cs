using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace ASUSP
{
    class DataConvert
    {
        static string path = "Base.csv";
        public static void WriteToCSV(Transaction transaction)
        {
            var csv = new StringBuilder();
            var number = transaction.ID.ToString();
            var start = transaction.startDate.ToString();
            var end = transaction.expiryDate.ToString();
            var type = transaction.productType.ToString();
            var code = transaction.productCode.ToString();
            var country = transaction.country.ToString();
            var city = transaction.city.ToString();
            var firm = transaction.firm.ToString();
            var cell = transaction.cell.ToString();
            var status = transaction.status.ToString();
            var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", 
                number, start, end, type, code, country, city, firm, cell, status);
            csv.Append(newLine);
            File.WriteAllText(path, csv.ToString());
        }

        public static void WriteToCSV(List<Transaction> transactions)
        {
            var csv = new StringBuilder();
            foreach (Transaction current in transactions)
            {
                var number = current.ID.ToString();
                var start = current.startDate.ToString();
                var end = current.expiryDate.ToString();
                var type = current.productType.ToString();
                var code = current.productCode.ToString();
                var country = current.country;
                var city = current.city;
                var firm = current.firm;
                var cell = current.cell.ConvertToString();
                var status = current.status.ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                number, start, end, type, code, country, city, firm, cell, status);
                csv.Append(newLine);
            }
            File.WriteAllText(path, csv.ToString());
        }

        public static List<Transaction> ReadFromCSV()
        {
            var lines = File.ReadAllText(path);
            var list = new List<Transaction>();
            foreach (var line in lines)
            {
                var cells = line.ToString().Split(',');
                Transaction transaction = new Transaction();
                transaction.ID = Convert.ToInt32(cells[0]);
                transaction.startDate = Convert.ToDateTime(cells[1]);
                transaction.expiryDate = Convert.ToDateTime(cells[2]);
                transaction.productType = Convert.ToInt32(cells[3]);
                transaction.productCode = Convert.ToInt32(cells[4]);
                transaction.country = cells[5];
                transaction.city = cells[6];
                transaction.firm = cells[7];
                transaction.cell = new Cell(cells[8]);
                transaction.status = Convert.ToBoolean(cells[9]);
                list.Add(transaction);
            }
            
            List<Transaction> transactions = new List<Transaction>();   
            return transactions;
        }
    }
}
