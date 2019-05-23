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

        public GasMotorcycle(string i_ModelName, string i_LicenceNumber, List<string> i_WheelsInfo, float i_EnergyLeftPercent, Motorcycle i_MotorcycleCommponent)
            : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity, i_EnergyLeftPercent)
        {
            AddWheels(i_WheelsInfo, Motorcycle.k_MaxAirPressure, Motorcycle.k_NumOfWheels);

            m_Motorcycle = i_MotorcycleCommponent;
        }
    }
}
                  
                  
