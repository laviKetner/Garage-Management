using System;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue = 0;
        private float m_MinValue = 0;

        public ValueOutOfRangeException()
        {
        }

        public ValueOutOfRangeException(string i_Message)
             : base(i_Message)
        {
        }

        public ValueOutOfRangeException(float i_MaxValue, float i_MinValue, float i_Value)
             : base(string.Format("The value {0} is out of range ({1}-{2})", i_Value, i_MinValue, i_MaxValue))
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
        }

        public ValueOutOfRangeException(float i_Value)
            : base(string.Format("The value {0} is out of range", i_Value))
        {
        }

        public ValueOutOfRangeException(Exception i_InnerException, float i_MaxValue, float i_MinValue, float i_Value)
            : base(string.Format("The value {0} is out of range", i_Value), i_InnerException)
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
        }
    }
}
