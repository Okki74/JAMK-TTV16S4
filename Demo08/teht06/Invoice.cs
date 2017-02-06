using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Invoice
    {
       
        public List<InvoiceItems> items;
        public string CustomerName;
        public double InvoiceTotal;

        public Invoice (string customerName)
        {
            CustomerName = customerName;
            items = new List<InvoiceItems>();
        }
        public void AddItems (InvoiceItems _items)
        {
            items.Add(_items);

        }
        public void CalcTotal()
        {
            
            foreach (InvoiceItems i in items)
            {
                InvoiceTotal += i.Total();
            }
            
        }
        public override string ToString()
        {
            CalcTotal();
            string str=(" Customer: "+CustomerName+ "invoice\n");
            str+=("=================================\n");
            foreach (InvoiceItems i in items)
            {
                str += i.ToString();
            }
            str+=("=================================\n");
            str += ("                   Total "+InvoiceTotal);
            return str;
        }
    }
}
