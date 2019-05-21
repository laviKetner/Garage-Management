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

        public GasTruck(string i_ModelName, string i_LicenceNumber, string i_WheelsManufacturerName, Truck i_TruckCommponent)
               : base(i_ModelName, i_LicenceNumber, k_GasType, k_MaxGasCapasity)
        {
            AddWheels(i_WheelsManufacturerName, Truck.k_MaxAirPressure, Truck.k_NumOfWheels);
            m_Truck = i_TruckCommponent;
        }
    }
}
