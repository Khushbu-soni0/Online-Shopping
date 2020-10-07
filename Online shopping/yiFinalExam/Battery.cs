using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yiFinalExam
{
    public class Battery : Item, IShipItem
    {
        public Battery()
        { 

        }

        public int Voltage { get; set; }

        public int ShipItem(string valname)
        {
            if (valname == "car batteries")
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        public bool ship
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
