namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        public readonly float r_MaxAirPreasure;
        private float m_AirPreasure = 0;


        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public Wheel(string i_ManufacturerName, float i_MaxAirPreasure)
        {
            m_ManufacturerName = i_ManufacturerName;

            // Maximum air preasure must to be positive
            if (i_MaxAirPreasure > 0)
            {
                r_MaxAirPreasure = i_MaxAirPreasure;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }
    }
}
