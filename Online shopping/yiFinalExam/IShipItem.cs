using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yiFinalExam
{
    public interface IShipItem
    {
        int ShipItem(string valname);
       
        bool ship { get; set; }
    }
}
