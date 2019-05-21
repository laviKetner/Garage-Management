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
        private string m_OwnerName;
        private string m_OwnerPhoneNum;
        private eVehicleStatus m_VihecleStatus = eVehicleStatus.InRepair;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public VehicleInsideGarage(string i_OwnersName, string i_OwnersPhoneNumber)
        {
            m_OwnerName = i_OwnersName;
            m_OwnerPhoneNum = i_OwnersPhoneNumber;
        }
    }
}
