using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    class ParkingGarage
    {
        private readonly Vehicle[,] parkingGarage;
        public IList<Vehicle> ParkedCars;

        public void AddSpace(ParkingSpace parkingSpace, Vehicle vehicle)
        {
            parkingGarage[parkingSpace.ParkingSpace1, parkingSpace.ParkingSpace1] = vehicle;
        }
        public ParkingSpace FindVehicle(Vehicle vehicle)
        {
            for (var spaces = 0; spaces < GarageSettings.GarageSize; spaces++)

                if (parkingGarage[spaces, spaces] == vehicle)
                    return ParkingSpace.At(parkingSpace1);

            throw new ArgumentException("The car is not in the garage");
        }
        public void ParkVehicle(ParkingSpace from, ParkingSpace to)
        {
            var parkingSpace = parkingGarage[from.ParkingSpace1, from.ParkingSpace1];
            if (parkingSpace == null) { return; }
            
            
            //Making space about to be used as occupied

            if (parkingGarage[to.ParkingSpace1,to.ParkingSpace1] != null)
            {
                SpaceOccupied(parkingGarage[to.ParkingSpace1,to.ParkingSpace1]);
            }
            //Marking space about to be empty as empty
            parkingGarage[to.ParkingSpace1, to.ParkingSpace1] = parkingGarage[to.ParkingSpace1,to.ParkingSpace1];

        }

        public delegate void SpaceOccupiedEventHandler(Vehicle vehicle);

        public event SpaceOccupiedEventHandler SpaceOccupied;
        protected virtual void SpaceOccupied1(Vehicle vehicle)
        {
            var handler = SpaceOccupied;
            if (handler != null) handler(vehicle);
        }


    }
}
