using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public enum eColor
    {
        red = 1,
        blue,
        black,
        gray
    }

    public class Car
    {
        public const byte k_NumOfWheels = 4;
        public const float k_MaxAirPressure = 31;
        public const byte k_MaxNumOfDoors = 5;
        public const byte k_MinNumOfDoors = 2;

        private eColor m_Color;
        private int m_NumOfDoors;
        private List<Wheel> m_Wheels = new List<Wheel>(k_NumOfWheels);

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public Car(eColor i_Color, int i_NumOfDoors)
        { 
            m_Color = i_Color;
            m_NumOfDoors = i_NumOfDoors;
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
            string carInfo = string.Format("{0}\nColor: {1}\nNumber of doors: {2}", m_Wheels[0].ToString(), m_Color.ToString(), m_NumOfDoors.ToString());

            return carInfo;
        }
    }
}
