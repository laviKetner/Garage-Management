using System;
namespace Ex03.GarageLogic
{
    public enum eVehicleStatus
    {
        InRepair,
        Fixed,
        Paid,
    }

    public class VehicleInsideGarage
    {
        private string m_OwnerName = null;
        private string m_OwnerPhoneNum = null;
        private eVehicleStatus m_VihecleStatus = eVehicleStatus.InRepair;
        private Vehicle m_Vechile = null;

        //-------------------------------------------------------------------------//
        //                               Constructor                               //
        //-------------------------------------------------------------------------//

        public VehicleInsideGarage(string i_OwnersName, string i_OwnersPhoneNumber)
        {
            m_OwnerName = i_OwnersName;
            m_OwnerPhoneNum = i_OwnersPhoneNumber;
        }

        public void ProcessVehicleInformation(string i_ModelName, string i_LicenceNumber, string i_WheelsManufacturerName, eVehicleType i_VehicleType, object i_InnerCommponent)
        {
            if (m_Vechile == null)
            {
                m_Vechile = VehicleMaker.CreateVehicle(i_ModelName, i_LicenceNumber, i_WheelsManufacturerName, i_VehicleType, i_InnerCommponent);
            }
            else
            {
                throw new ArgumentException("Vehicle already in garage");
            }
        }
    }
}

