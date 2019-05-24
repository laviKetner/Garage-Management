using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class GasCar : GasVehicle
    {
        private const eGasType k_GasType = eGasType.Octan96;
        private const float k_MaxGasCapasity = 55f;

        private Car m_Car;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public GasCar(string i_ModelName, string i_LicenceNumber, List<string> i_WheelsInfo, float i_EnergyLeftPercent, Car i_InnerVehicleInfo) : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity, i_EnergyLeftPercent)
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
            string infoGasCar = string.Format("{0}\n{1}", base.ToString(), m_Car.ToString());

            return infoGasCar;
        }
    }
}
