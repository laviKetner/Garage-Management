namespace Ex03.GarageLogic
{
    public enum eLicenceType
    {
        A,
        A1,
        B1,
        B2,
    }

    public class Motorcycle
    {
        //All the Motorcycles (Gas and Electric) have the same number of wheels(2), and the same Max air pressure(33)
        public const byte k_NumberOfWheels = 2;
        public const float k_MaxAirPressure = 33;

        private eLicenceType m_LicenceType;
        private readonly int m_EngineCapacity;
    }
}
