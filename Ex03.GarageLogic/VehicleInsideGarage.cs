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
    }
}
