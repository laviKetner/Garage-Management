using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class ElectricCar : ElectricVehicle
    {
        private const float k_MaxBatteryTime = 1.8f; // Represent the max time the battry hold.
        private Car m_Car;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public ElectricCar(string i_ModelName, string i_LicenseNumber, List<string> i_WheelsInfo, float i_EnergyLeftPercent, Car i_InnerVehicleInfo) : base(i_ModelName, i_LicenseNumber, k_MaxBatteryTime, i_EnergyLeftPercent)
        {
            m_Car = i_InnerVehicleInfo;
            m_Car.AddWheels(i_WheelsInfo);
        }

        public Car GetCar
        {
            get
            {
                return m_Car;
            }
        }

        public override string ToString()
        {
            string infoElectricCar = string.Format("{0}\n{1}", base.ToString(), m_Car.ToString());

            return infoElectricCar;
        }
    }
}
