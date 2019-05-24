using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : ElectricVehicle
    {
        private const float k_MaxBatteryTime = 1.4f; // Represent the max time the battry hold.
        private Motorcycle m_Motorcycle;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public ElectricMotorcycle(string i_ModelName, string i_LicenseNumber, List<string> i_WheelsInfo, float i_EnergyLeftPercent, Motorcycle i_InnerVehicleInfo) : base(i_ModelName, i_LicenseNumber, k_MaxBatteryTime, i_EnergyLeftPercent)
        {
            m_Motorcycle = i_InnerVehicleInfo;
            m_Motorcycle.AddWheels(i_WheelsInfo);
        }

        public Motorcycle GetMotorcycle
        {
            get
            {
                return m_Motorcycle;
            }
        }

        public override string ToString()
        {
            string infoElectricMotorcycle = string.Format("{0}\n{1}", base.ToString(), m_Motorcycle.ToString());

            return infoElectricMotorcycle;
        }
    }
}
