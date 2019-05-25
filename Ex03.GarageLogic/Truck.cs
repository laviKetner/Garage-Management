using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public sealed class Truck
    {
        public const byte k_NumOfWheels = 12;
        public const float k_MaxAirPressure = 26;

        private readonly float r_TrunkCapacity;
        private bool m_IsContaineHazardousMaterials;
        private List<Wheel> m_Wheels = new List<Wheel>(k_NumOfWheels);

        //-------------------------------------------------------------------------//
        //                              Constructor                                //
        //-------------------------------------------------------------------------//
        public Truck(float i_TrunkCapacity, bool i_IsContaineHazardousMaterials)
        {
            r_TrunkCapacity = i_TrunkCapacity;
            m_IsContaineHazardousMaterials = i_IsContaineHazardousMaterials;
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
            string truckInfo = string.Format("{0}\nTrunk Capacity: {1}\nContaine hazardous materials: {2}", m_Wheels[0].ToString(), r_TrunkCapacity.ToString(), m_IsContaineHazardousMaterials.ToString());

            return truckInfo;
        }
    }
}
