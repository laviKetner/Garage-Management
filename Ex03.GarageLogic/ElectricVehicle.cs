namespace Ex03.GarageLogic
{
    public class ElectricVehicle : Vehicle
    {
        private readonly float r_MaxBatteryTimeInHour; 
        private float m_CurrentBatteryTimeLeftInHour;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public ElectricVehicle(string i_ModelName, string i_LicenceNumber, float i_MaxBatteryTime, float i_EnergyLeftPercent)
                               : base(i_ModelName, i_LicenceNumber, i_EnergyLeftPercent)
        {
            r_MaxBatteryTimeInHour = i_MaxBatteryTime;
            m_CurrentBatteryTimeLeftInHour = (r_MaxBatteryTimeInHour * i_EnergyLeftPercent) / 100; // Conversion from percent to number that represent the current time in hours.
        }

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void Charge(float i_MinutesOfChargeToAdd)
        {
            if (((i_MinutesOfChargeToAdd / 60) + m_CurrentBatteryTimeLeftInHour) > r_MaxBatteryTimeInHour || i_MinutesOfChargeToAdd < 0)
            {
                throw new ValueOutOfRangeException((r_MaxBatteryTimeInHour - m_CurrentBatteryTimeLeftInHour) * 60, 0, i_MinutesOfChargeToAdd);
            }
            else
            {
                m_CurrentBatteryTimeLeftInHour += i_MinutesOfChargeToAdd / 60;
                EnergyLeftPercent = (m_CurrentBatteryTimeLeftInHour * 100) / r_MaxBatteryTimeInHour;
            }
        }

        public override string ToString()
        {
            string electricVehicleinfo = string.Format("{0}Charge hours left: {1}", base.ToString(), m_CurrentBatteryTimeLeftInHour.ToString());

            return electricVehicleinfo;
        }
    }
}
