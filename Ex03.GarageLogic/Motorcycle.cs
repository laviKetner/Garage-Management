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
        public const byte k_NumOfWheels = 2;
        public const float k_MaxAirPressure = 33;

        private eLicenceType m_LicenceType;
        private readonly int m_EngineCapacity;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public Motorcycle(eLicenceType i_LicenseType, int i_EngineCapacity)
        {
            if (i_EngineCapacity > 0)
            {
                m_EngineCapacity = i_EngineCapacity;
                m_LicenceType = i_LicenseType;
            }
            else
            {
                throw new ValueOutOfRangeException(i_EngineCapacity);
            }
        }
    }
}
