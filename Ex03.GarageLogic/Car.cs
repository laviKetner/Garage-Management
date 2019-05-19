
namespace Ex03.GarageLogic
{
    public enum eColor
    {
        red,
        blue,
        black,
        gray
    }

    public class Car
    {
        //All the cars (Gas and Electric) have the same number of wheels(4), and the same Max air pressure(31)
        public const byte k_NumberOfWheels = 4;
        public const float k_MaxAirPressure = 31;

        private const byte k_MaxNumOfDoors = 5;
        private const byte k_MinNumOfDoors = 2;

        private eColor m_Color;
        private byte m_NumOfDoors;

    }
}
