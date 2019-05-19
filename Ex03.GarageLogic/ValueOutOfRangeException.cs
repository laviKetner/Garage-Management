using System;
namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue = 0;
        private float m_MinValue = 0;
    }
}
