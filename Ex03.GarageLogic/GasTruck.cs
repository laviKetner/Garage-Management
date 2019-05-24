using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class GasTruck : GasVehicle
    {
        private const eGasType k_GasType = eGasType.Soler;
        private const float k_MaxGasCapasity = 110;

        private Truck m_Truck;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public GasTruck(string i_ModelName, string i_LicenceNumber, List<string> i_WheelsInfo, float i_EnergyLeftPercent, Truck i_TruckCommponent) : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity, i_EnergyLeftPercent)
        {
            m_Truck = i_TruckCommponent;
            m_Truck.AddWheels(i_WheelsInfo);
        }

        public Truck GetTruck
        {
            get
            {
                return m_Truck;
            }
        }

        public override string ToString()
        {
            string infoGasTruck = string.Format("{0}\n{1}", base.ToString(), m_Truck.ToString());

            return infoGasTruck;
        }
    }
}
