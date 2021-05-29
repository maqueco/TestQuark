using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuark
{
    public class Quote
    {
        public int id;
        public DateTime date;
        public Guid sellerCode;
        public string wear;
        public int amountWear;
        public int result;

        public void SetIdQuote()
        {

        }
        public void SetDate()
        {
            date = DateTime.Now;
            Console.WriteLine(date.ToString());
        }

        public Guid GetSellerCode(Guid code)
        {
            sellerCode = code;
            return sellerCode;
        }
        public string QuoteWear()
        {
            return wear;
        }
        public int AmountWear()
        {
            return amountWear;
        }
    }
}
