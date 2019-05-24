using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public enum eLicenceType
    {
        A = 1,
        A1,
        A2,
        B,
    }

    public class Motorcycle
    {
        // All the Motorcycles (Gas and Electric) have the same number of wheels(2), and the same Max air pressure(33)
        private readonly int m_EngineCapacity;
        public const byte k_NumOfWheels = 2;
        public const float k_MaxAirPressure = 33;
        private eLicenceType m_LicenceType;
        private List<Wheel> m_Wheels = new List<Wheel>(k_NumOfWheels);

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public Motorcycle(eLicenceType i_LicenseType, int i_EngineCapacity)
        {
            m_EngineCapacity = i_EngineCapacity;
            m_LicenceType = i_LicenseType;
        }

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void AddWheels(List<string> i_WheelsInfo)
        {
            for (byte i = 0; i < k_NumOfWheels; i++)
            {
                string manufacturerName = i_WheelsInfo[0];
                float airPressure = float.Parse(i_WheelsInfo[1]);

                Wheel currentWheel = new Wheel(manufacturerName, k_MaxAirPressure, airPressure);
                m_Wheels.Add(currentWheel);
            }
        }

        public void InflateWheelsToMax()
        {
            foreach (Wheel currentWheel in m_Wheels)
            {
                currentWheel.SetAirPreasureToMax();
            }
        }

        public override string ToString()
        {
            string motorcycleInfo = string.Format("{0}\nEngine Capacity: {1}\nLicence type: {2}", m_Wheels[0].ToString(), m_EngineCapacity.ToString(), m_LicenceType.ToString());

            return motorcycleInfo;
        }
    }
}
