using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class GasMotorcycle : GasVehicle
    {
        private const eGasType k_GasType = eGasType.Octan95;
        private const float k_MaxGasCapasity = 8f;

        private Motorcycle m_Motorcycle;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public GasMotorcycle(string i_ModelName, string i_LicenceNumber, List<string> i_WheelsInfo, float i_EnergyLeftPercent, Motorcycle i_InnerVehicleInfo)
            : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity, i_EnergyLeftPercent)
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
            string infoGasMotorcycle = string.Format("{0}\n{1}", base.ToString(), m_Motorcycle.ToString());

            return infoGasMotorcycle;
        }
    }
}      
