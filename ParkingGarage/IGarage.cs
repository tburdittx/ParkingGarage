using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    interface IGarage
    {
        string AmountOfSpaces { get; set; }
        string WidthOfSpaces { get; set; }
        bool IsSpaceAvailable();

    }
}
