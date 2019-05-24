using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LicenseNum;
        private float m_EnergyLeftPercent;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        protected Vehicle(string i_ModelName, string i_LicenseNumber, float i_EnergyLeftPercent)
        {
            m_ModelName = i_ModelName;
            m_LicenseNum = i_LicenseNumber;
            m_EnergyLeftPercent = i_EnergyLeftPercent;
        }

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void InflateWheelsToMax()
        {
            if (this is ElectricCar)
            {
                ((ElectricCar)this).GetCar.InflateWheelsToMax();
            }
            else if (this is GasCar)
            {
                ((GasCar)this).GetCar.InflateWheelsToMax();
            }
            else if (this is ElectricMotorcycle)
            {
                ((ElectricMotorcycle)this).GetMotorcycle.InflateWheelsToMax();
            }
            else if (this is GasMotorcycle)
            {
                ((GasMotorcycle)this).GetMotorcycle.InflateWheelsToMax();
            }
            else if (this is GasTruck)
            {
                ((GasTruck)this).GetTruck.InflateWheelsToMax();
            }
        }

        public float EnergyLeftPercent
        {
            get
            {
                return m_EnergyLeftPercent;
            }

            set
            {
                m_EnergyLeftPercent = value;
            }
        }

        public string LicenseNum
        {
            get
            {
                return m_LicenseNum;
            }
        }

        public override string ToString()
        {
            string vehicleInformation = string.Format("Model name: {0}\nLicense number: {1}\nEnergy left: {2}\n", m_ModelName, m_LicenseNum, m_EnergyLeftPercent.ToString());

            return vehicleInformation;
        }
    }
}
