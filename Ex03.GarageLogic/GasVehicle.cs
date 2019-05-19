namespace Ex03.GarageLogic
{
    public enum eGasType
    {
        Octan95,
        Octan96,
        Octan98,
        Soler,
    }

    public class GasVehicle
    {
        private readonly float r_MaxGasCapasity; //We need to get this number from GasCar or GasMotorcycle.
        private float m_CurrentGasCapasity;
        private eGasType m_GasType;
    }
}
