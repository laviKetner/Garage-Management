using System;

namespace Ex03.GarageLogic
{
    public enum eGasType
    {
        Octan95 = 1,
        Octan96,
        Octan98,
        Soler,
    }

    public class GasVehicle : Vehicle
    {
        private readonly float r_MaxGasCapasity; 
        private eGasType m_GasType; 
        private float m_CurrentGasCapasity;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public GasVehicle(string i_ModelName, string i_LicenceNumber, eGasType i_GasType, float i_MaxGasCapasity, float i_EnergyLeftPercent) : base(i_ModelName, i_LicenceNumber, i_EnergyLeftPercent)
        {
            r_MaxGasCapasity = i_MaxGasCapasity;
            m_GasType = i_GasType;
            m_CurrentGasCapasity = (r_MaxGasCapasity * i_EnergyLeftPercent) / 100; // Conversion from percent to number that represent the liters.
        }

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void Refuel(eGasType i_GasType, float i_AmountOfGasToAdd)
        {
            if (i_GasType != m_GasType)
            {
                throw new ArgumentException("Incorrect fuel type");
            }
            else if (i_AmountOfGasToAdd > 0 && (i_AmountOfGasToAdd + m_CurrentGasCapasity) <= r_MaxGasCapasity)
            {
                m_CurrentGasCapasity += i_AmountOfGasToAdd;
                EnergyLeftPercent = (m_CurrentGasCapasity * 100) / r_MaxGasCapasity;
            }
            else
            {
                throw new ValueOutOfRangeException(r_MaxGasCapasity - m_CurrentGasCapasity, 0, i_AmountOfGasToAdd);
            }
        }

        public override string ToString()
        {
            string GasVehicleInfo = string.Format("{0}Gas type: {1}\nCurrent gas amount: {2}", base.ToString(), m_GasType.ToString(), m_CurrentGasCapasity.ToString());

            return GasVehicleInfo;
        }
    }
}
