using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    /*
     States when a vehicle has entered the garage and if it has parked 
     
     */
    class VehicleParked
    {
        public bool VehicleParked1;
     

        public bool CarHasEntered()
        {
            return true;
        }
        public void Occupy (ParkingGarage parkingGarage, ParkingSpace parkingSpace)
        {
            var currentSpace = parkingGarage.FindVehicle(this);
            parkingGarage.ParkVehicle(currentSpace, parkingSpace);
            VehicleParked1 = true;
        }
    }
}
