using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        private string m_ModelName;
        private string m_LicenceNum;
        private float m_EnergyLeftPercent;
        private readonly List<Wheel> r_Wheels = new List<Wheel>();
    }
}
