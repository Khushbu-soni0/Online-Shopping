using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yiFinalExam
{
    public class Item
    {
        internal string tireCount;

        public Item()
        { 
        
        }

        public string itemtype { get; set; }

        public string itemname { get; set; }

        public string TireModelName { get; set; }

        public int wheeldiameter { get; set; }

        public int Voltage { get; set; }

        public int length { get; set; }

        public int itemcostdisplay { get; set; }

        public int itemweightdisplya { get; set; }

        public string Shipping { get; set; }

        public int shippingprice2 { get; set; }

        public int TotalCosting { get; set; }

        public int qnty { get; set; }

    }
}
