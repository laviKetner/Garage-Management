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

        public void ChangeVihecleStatus(string i_LicenseNumber, eVehicleStatus i_VehicleStatus)
        {
            if(isVihecleExistInGarage(i_LicenseNumber))
            {
                m_VehiclesInGarage[i_VehicleStatus.GetHashCode()].VihecleStatus = i_VehicleStatus;
            }
            else
            {
                throw new Exception("This vehicle doesn't found in the garage.");
            }
        }

        public bool isVihecleExistInGarage(string i_LicenseNumber)
        {
            return m_VehiclesInGarage.ContainsKey(i_LicenseNumber.GetHashCode());
        }
    }
}
