namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle: ElectricVehicle
    {
        private const float k_MaxBatteryTime = 1.4f; // Represent the max time the battry hold.
        private Motorcycle m_Motorcycle;


        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public ElectricMotorcycle(string i_ModelName, string i_LicenseNumber, string i_WheelsManufacturerName, Motorcycle i_MotorcycleCommponent)
                                 : base(i_ModelName, i_LicenseNumber, k_MaxBatteryTime)
        {
            AddWheels(i_WheelsManufacturerName, Motorcycle.k_MaxAirPressure, Motorcycle.k_NumOfWheels);
            m_Motorcycle = i_MotorcycleCommponent;
        }
    }
}
