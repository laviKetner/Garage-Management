namespace Ex03.GarageLogic
{
    public class Truck
    {
        public const byte k_NumOfWheels = 12;
        public const float k_MaxAirPressure = 26;

        private bool m_IsContaineHazardousMaterials;
        public readonly float r_TrunkCapacity;

        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//
        public Truck(float i_TrunkCapacity, bool i_IsContaineHazardousMaterials)
        {
            if (i_TrunkCapacity > 0)
            {
                r_TrunkCapacity = i_TrunkCapacity;
                m_IsContaineHazardousMaterials = i_IsContaineHazardousMaterials;
            }
            else
            {
                throw new ValueOutOfRangeException(i_TrunkCapacity);
            }
        }
    }
}
