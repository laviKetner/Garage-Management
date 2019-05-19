using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public enum eMenu
    {
        InsertVehicle,
        GetLicenceNumbers,
        ChangeVihecleState,
        InflateWheelsToMax,
        RefuleVihecle,
        ChargeVihecle,
        GetVihecleDataMsg,
        Exit
    }

    class GarageUI
    {
        private const byte k_NumberOfMenuOptions = 8;
        private Garage m_Garage = new Garage();

    }
}
