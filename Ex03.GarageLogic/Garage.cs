using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<int, VehicleInsideGarage> m_VehiclesInGarage = new Dictionary<int, VehicleInsideGarage>();

        public bool isVehicleExistInGarage(string i_LicenseNumber)
        {
            return m_VehiclesInGarage.ContainsKey(i_LicenseNumber.GetHashCode());
        }
    }
}
