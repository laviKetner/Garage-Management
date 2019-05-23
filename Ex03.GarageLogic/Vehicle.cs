using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenceNum;
        private float m_EnergyLeftPercent;
        private List<Wheel> m_Wheels = new List<Wheel>();

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        protected Vehicle(string i_ModelName, string i_LicenseNumber, float i_EnergyLeftPercent)
        {
            if (!string.IsNullOrEmpty(i_ModelName) && !string.IsNullOrEmpty(i_LicenseNumber))
            {
                m_ModelName = i_ModelName;
                m_LicenceNum = i_LicenseNumber;
                m_EnergyLeftPercent = i_EnergyLeftPercent;
            }
            else
            {
                throw new ArgumentException("Empty field");
            }
        }

        protected void AddWheels(List<string> i_WheelsInfo, float i_MaxAirPreasure, byte i_NumberOfWheels)
        {
            for (byte i = 0; i < i_NumberOfWheels; i++)
            {
                string manufacturerName = i_WheelsInfo[0];
                float airPressure = float.Parse(i_WheelsInfo[1]);

                Wheel currentWheel = new Wheel(manufacturerName, i_MaxAirPreasure, airPressure);
                m_Wheels.Add(currentWheel);
            }
        }
    }
}
