using System;
using System.Text;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<int, VehicleInsideGarage> m_VehiclesInGarage = new Dictionary<int, VehicleInsideGarage>();

        //-------------------------------------------------------------------------//
        //                             Pubilc Methods                              //
        //-------------------------------------------------------------------------//
        public void InsertVehicle(VehicleInsideGarage i_VehicleInGarage)
        {
            string licenseNumber = i_VehicleInGarage.Vehicle.LicenseNum;
            m_VehiclesInGarage.Add(licenseNumber.GetHashCode(), i_VehicleInGarage);
        }

        public void RefuleVehicle(string i_LicenseNumber, eGasType i_GasType, float i_GasAmmount)
        {
            Vehicle relevantVehicle = getVehicle(i_LicenseNumber);

            if (relevantVehicle != null)
            {
                GasVehicle relevantgasVehicle = relevantVehicle as GasVehicle;

                if (relevantgasVehicle != null)
                {
                    relevantgasVehicle.Refuel(i_GasType, i_GasAmmount);
                }
                else
                {
                    throw new ArgumentException("You can not refule this vehicle type.");
                }
            }
        }

        public void ChargeVehicle(string i_LicenseNumber, float i_MinutesOfChargeToAdd)
        {
            Vehicle relevantVehicle = getVehicle(i_LicenseNumber);

            if (relevantVehicle != null)
            {
                ElectricVehicle relevanElectrictVehicle = relevantVehicle as ElectricVehicle;
                if (relevanElectrictVehicle != null)
                {
                    relevanElectrictVehicle.Charge(i_MinutesOfChargeToAdd);
                }
                else
                {
                    throw new ArgumentException("You can not charge this vehicle type...");
                }
            }
        }

        public void ChangeVehicleStatus(string i_LicenseNumber, eVehicleStatus i_VehicleStatus)
        {
            if (IsVehicleExistInGarage(i_LicenseNumber))
            {
                m_VehiclesInGarage[i_LicenseNumber.GetHashCode()].VehicleStatus = i_VehicleStatus;
            }
            else
            {
                throw new Exception("This vehicle doesn't found in the garage.");
            }
        }

        public void InflateWheelsVehicleToMax(string i_LicenseNumber)
        {
            Vehicle relevantVehicle = getVehicle(i_LicenseNumber);

            if (relevantVehicle != null)
            {
                relevantVehicle.InflateWheelsToMax();
            }
            else
            {
                throw new Exception("This vehicle does not exist in the database");
            }
        }

        public bool IsVehicleExistInGarage(string i_LicenseNumber)
        {
            return m_VehiclesInGarage.ContainsKey(i_LicenseNumber.GetHashCode());
        }

        public string GetLicenceNumbersByVehicleStatus(eVehicleStatus i_VehicleState)
        {
            string EmptyListMsg = "Empty list.";
            StringBuilder listOfVehicles = new StringBuilder();

            if (m_VehiclesInGarage.Count != 0)
            {
                foreach (KeyValuePair<int, VehicleInsideGarage> currentGarageVehicle in m_VehiclesInGarage)
                {
                    if (currentGarageVehicle.Value.VehicleStatus == i_VehicleState)
                    {
                        listOfVehicles.AppendLine(currentGarageVehicle.Value.Vehicle.LicenseNum);
                    }
                }
            }

            if (listOfVehicles.Length == 0)
            {
                listOfVehicles.Append(EmptyListMsg);
            }

            return listOfVehicles.ToString();
        }

        public string GetVehicleDataMsg(string i_LicenseNumber)
        {
            string VehicleDataMsg = string.Empty;

            if (IsVehicleExistInGarage(i_LicenseNumber))
            {
                int key = i_LicenseNumber.GetHashCode();
                VehicleDataMsg = m_VehiclesInGarage[key].ToString();
            }
            else
            {
                throw new Exception("This vehicle does not exist in the garage");
            }

            return VehicleDataMsg;
        }

        //-------------------------------------------------------------------------//
        //                            Private Methods                              //
        //-------------------------------------------------------------------------//
        private Vehicle getVehicle(string i_LicenseNumber)
        {
            Vehicle relevantVehicle = null;
            int key = i_LicenseNumber.GetHashCode();

            if (IsVehicleExistInGarage(i_LicenseNumber))
            {
                relevantVehicle = m_VehiclesInGarage[key].Vehicle;
            }
            else
            {
                throw new Exception("This vehicle doesn't found in the garage.");
            }

            return relevantVehicle;
        }
    }
}
