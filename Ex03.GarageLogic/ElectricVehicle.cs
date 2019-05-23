namespace Ex03.GarageLogic
{
    public class ElectricVehicle : Vehicle
    {
        private readonly float r_MaxBatteryTime; //We need to get this number from ElectricCar or ElectricMotorcycle.
        private float m_BatteryTimeLeft;


        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public ElectricVehicle(string i_ModelName, string i_LicenceNumber, float i_MaxBatteryTime , float i_EnergyLeftPercent)
       : base(i_ModelName, i_LicenceNumber, i_EnergyLeftPercent)
        {
            if (i_MaxBatteryTime > 0)
            {
                r_MaxBatteryTime = i_MaxBatteryTime;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }

    }
}
