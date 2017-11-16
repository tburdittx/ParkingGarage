using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    class Vehicle
    {
        public bool VehicleParked;
     

        public bool CarHasEntered()
        {
            return true;
        }
        public void Occupy (ParkingGarage parkingGarage, ParkingSpace parkingSpace)
        {
            var currentSpace = parkingGarage.FindVehicle(this);
            parkingGarage.ParkVehicle(currentSpace, parkingSpace);
            VehicleParked = true;
        }
    }
}
