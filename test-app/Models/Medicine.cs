using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_app.Models
{
    public class Medicine
    {
        public int id { get; set; }
        public string  FullName
        {
            get;
            set;
        }
        public string Brand
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        public int Quantity { get; set; }

        public DateTime Expiry_Date { get; set; }

        public string Notes { get; set; }
    }
}