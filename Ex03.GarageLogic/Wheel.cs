namespace Ex03.GarageLogic
{
    public class Wheel
    {
        public readonly float r_MaxAirPreasure;
        private string m_ManufacturerName;
        private float m_AirPreasure;



        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public Wheel(string i_ManufacturerName, float i_MaxAirPreasure, float i_CurrentAirPreasure)
        {
            m_ManufacturerName = i_ManufacturerName;
            m_AirPreasure = i_CurrentAirPreasure;
            r_MaxAirPreasure = i_MaxAirPreasure;
        }
    }
}
