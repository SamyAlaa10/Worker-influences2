using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_influences.TablesData
{
   public class PurchasesOpj
    {
        public int id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Depart { get; set; }
        public string Company { get; set; }
        public DateTime DatePurchases { get; set; }
        double valu = 0;
        public double value
        {
            get { return valu; }
            set
            {
                if (value < 0)
                {
                    valu = 0;
                }
                else
                {
                    valu = value;
                }
            }
        }
        public string namPurchases { get; set; }
        public string Place_B_Purchases { get; set; }
        public string Nots { get; set; }
        public DateTime DateEnter { get; set; }
        public bool caneEdit { get; set; }
        public string NameEnter { get; set; }
    }
}
