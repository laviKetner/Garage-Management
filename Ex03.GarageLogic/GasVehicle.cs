namespace Ex03.GarageLogic
{
    public enum eGasType
    {
        Octan95,
        Octan96,
        Octan98,
        Soler,
    }

    public class GasVehicle: Vehicle
    {
        private readonly float r_MaxGasCapasity; //We need to get this number from GasCar or GasMotorcycle.
        private eGasType m_GasType; //We need to get this number from GasCar or GasMotorcycle.
        private float m_CurrentGasCapasity;


        //-------------------------------------------------------------------------//
        //                                Constructor                              //
        //-------------------------------------------------------------------------//

        public GasVehicle(string i_ModelName, string i_LicenceNumber, eGasType i_GasType, float i_MaxGasCapasity)
       : base(i_ModelName, i_LicenceNumber)
        {
            if (i_MaxGasCapasity > 0)
            {
                r_MaxGasCapasity = i_MaxGasCapasity;
                m_GasType = i_GasType;
            }
            else
            {
                throw new ValueOutOfRangeException("Can not enter negative values...");
            }
        }
    }
}
