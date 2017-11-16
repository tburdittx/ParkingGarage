using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    public struct ParkingSpace
    {
        public readonly int ParkingSpace1;

        public ParkingSpace(int parkingSpace1)
        {
            ParkingSpace1 = parkingSpace1;
        }

      
        public static ParkingSpace At(int parkingSpace1)
        {
            return new ParkingSpace(parkingSpace1);
        }
        public bool Equals (ParkingSpace parkingSpace)
        {
            return ParkingSpace1 == parkingSpace.ParkingSpace1;
        }
        public override string ToString()
        {
            return string.Format("Parking Space {0}", ParkingSpace1);
        }

    }
}
