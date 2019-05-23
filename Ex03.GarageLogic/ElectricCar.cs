using System.Collections.Generic;
namespace Ex03.GarageLogic
{
    public class ElectricCar: ElectricVehicle
    {
        private const float k_MaxBatteryTime = 1.8f; // Represent the max time the battry hold.
        private Car m_Car;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public ElectricCar(string i_ModelName, string i_LicenseNumber, List<string> i_WheelsInfo,float i_EnergyLeftPercent, Car i_CarCommponent)
                           : base(i_ModelName, i_LicenseNumber, k_MaxBatteryTime, i_EnergyLeftPercent)
        {
            AddWheels(i_WheelsInfo, Car.k_MaxAirPressure, Car.k_NumOfWheels);
            m_Car = i_CarCommponent;
        }
    }
}
