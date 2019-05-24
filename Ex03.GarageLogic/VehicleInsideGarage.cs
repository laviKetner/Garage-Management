using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public enum eVehicleStatus
    {
        InRepair = 1,
        Fixed,
        Paid,
    }

    public class VehicleInsideGarage
    {
        private string m_OwnerName = null;
        private string m_OwnerPhoneNum = null;
        private eVehicleStatus m_VehicleStatus = eVehicleStatus.InRepair;
        private Vehicle m_Vechile = null;

        //-------------------------------------------------------------------------//
        //                               Constructor                               //
        //-------------------------------------------------------------------------//
        public VehicleInsideGarage(string i_OwnersName, string i_OwnersPhoneNumber)
        {
            m_OwnerName = i_OwnersName;
            m_OwnerPhoneNum = i_OwnersPhoneNumber;
        }

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void EnterVehicleIntoGarage(string i_ModelName, string i_LicenceNumber, List<string> i_WheelInfo, float i_EnergyLeftPercent, eVehicleType i_VehicleType, object i_InnerVehicleInfo)
        {
            if (m_Vechile == null)
            {
                m_Vechile = VehicleMaker.CreateVehicle(i_ModelName, i_LicenceNumber, i_WheelInfo, i_EnergyLeftPercent, i_VehicleType, i_InnerVehicleInfo);
            }
            else
            {
                throw new ArgumentException("Vehicle already in garage");
            }
        }

        public eVehicleStatus VehicleStatus
        {
            get
            {
                return m_VehicleStatus;
            }

            set
            {
                m_VehicleStatus = value;
            }
        }

        public Vehicle Vehicle
        {
            get
            {
                return m_Vechile;
            }
        }

        public override string ToString()
        {
            string infoOnCarInGarage = string.Format("\n\nOwner Information:\n------------------\nName: {0}\nPhone number: {1}\n\nVehicle information:\n------------------\nVehicle garage repair status: {2}\n{3}\n", m_OwnerName, m_OwnerPhoneNum, m_VehicleStatus.ToString(), m_Vechile.ToString());

            return infoOnCarInGarage;
        }
    }
}
