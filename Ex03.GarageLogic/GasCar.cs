namespace Ex03.GarageLogic
{
    public class GasCar: GasVehicle
    {
        private const eGasType k_GasType = eGasType.Octan96;
        private const float k_MaxGasCapasity = 55f;

        private Car m_Car;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public GasCar(string i_ModelName, string i_LicenceNumber, string i_WheelsManufacturerName, Car i_CarCommponent)
                     : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity)
        {
            AddWheels(i_WheelsManufacturerName, Car.k_MaxAirPressure, Car.k_NumOfWheels);
            m_Car = i_CarCommponent;
        }
    }
}
