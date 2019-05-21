using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenceNum;
        private float m_EnergyLeftPercent;
        private readonly List<Wheel> r_Wheels = new List<Wheel>();

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        protected Vehicle(string i_ModelName, string i_LicenseNumber)
        {
            if (!string.IsNullOrEmpty(i_ModelName) && !string.IsNullOrEmpty(i_LicenseNumber))
            {
                m_ModelName = i_ModelName;
                m_LicenceNum = i_LicenseNumber;
            }
            else
            {
                throw new ArgumentException("Empty field");
            }
        }

        protected void AddWheels(string i_ManufacturerName, float i_MaxAirPreasure, byte i_NumberOfWheels)
        {
            for (byte i = 0; i < i_NumberOfWheels; i++)
            {
                Wheel currentWheel = new Wheel(i_ManufacturerName, i_MaxAirPreasure);
                r_Wheels.Add(currentWheel);
            }
        }
    }
}
