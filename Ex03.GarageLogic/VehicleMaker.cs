namespace Ex03.GarageLogic
{
    public enum eVehicleType
    {
        ElectricCar = 1,
        GasCar,
        ElectricMotorcycle,
        GasMotorcycle,
        GasTruck,
    }

    public class VehicleMaker
    {
        public static Vehicle CreateVehicle(string i_ModelName, string i_LicenceNumber, string i_WheelsManufacturerName, eVehicleType i_VehicleType, object i_InnerVehicleInfo)
        {
            Vehicle newVehicle = null;

            if (i_VehicleType == eVehicleType.ElectricCar)
            {
                newVehicle = new ElectricCar(i_ModelName, i_LicenceNumber, i_WheelsManufacturerName, (Car)i_InnerVehicleInfo);
            }
            else if (i_VehicleType == eVehicleType.GasCar)
            {
                newVehicle = new GasCar(i_ModelName, i_LicenceNumber, i_WheelsManufacturerName, (Car)i_InnerVehicleInfo);
            }
            else if (i_VehicleType == eVehicleType.ElectricMotorcycle)
            {
                newVehicle = new ElectricMotorcycle(i_ModelName, i_LicenceNumber, i_WheelsManufacturerName, (Motorcycle)i_InnerVehicleInfo);
            }
            else if (i_VehicleType == eVehicleType.GasMotorcycle)
            {
                newVehicle = new GasMotorcycle(i_ModelName, i_LicenceNumber, i_WheelsManufacturerName, (Motorcycle)i_InnerVehicleInfo);
            }
            else if (i_VehicleType == eVehicleType.GasTruck)
            {
                newVehicle = new GasTruck(i_ModelName, i_LicenceNumber, i_WheelsManufacturerName, (Truck)i_InnerVehicleInfo);
            }

            return newVehicle;
        }
    }
}
