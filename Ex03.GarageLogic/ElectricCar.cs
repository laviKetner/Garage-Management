namespace Ex03.GarageLogic
{
    public class ElectricCar: ElectricVehicle
    {
        private const float k_MaxBatteryTime = 1.8f; // Represent the max time the battry hold.
        private Car m_Car;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public ElectricCar(string i_ModelName, string i_LicenseNumber, string i_WheelsManufacturerName, Car i_CarCommponent)
                           : base(i_ModelName, i_LicenseNumber, k_MaxBatteryTime)
        {
            AddWheels(i_WheelsManufacturerName, Car.k_MaxAirPressure, Car.k_NumOfWheels);
            m_Car = i_CarCommponent;
        }
    }
}
