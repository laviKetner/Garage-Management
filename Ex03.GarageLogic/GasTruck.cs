using System.Collections.Generic;
namespace Ex03.GarageLogic
{
    public class GasTruck: GasVehicle
    {
        private const eGasType k_GasType = eGasType.Soler;
        private const float k_MaxGasCapasity = 110;

        private Truck m_Truck;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public GasTruck(string i_ModelName, string i_LicenceNumber, List<string> i_WheelsInfo,float i_EnergyLeftPercent, Truck i_TruckCommponent)
               : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity, i_EnergyLeftPercent)
        {
            AddWheels(i_WheelsInfo, Truck.k_MaxAirPressure, Truck.k_NumOfWheels);
            m_Truck = i_TruckCommponent;
        }
    }
}
