namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private readonly float r_MaxAirPreasure;
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

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void SetAirPreasureToMax()
        {
            m_AirPreasure = r_MaxAirPreasure;
        }

        public override string ToString()
        {
            return string.Format("Manufacturer name: {0}\nAir preasure in all wheels: {1}", m_ManufacturerName, m_AirPreasure);
        }
    }
}
