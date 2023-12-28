using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    public struct Vehicle
    {
        // A structure is a user defned data type same like a class and it is used when there is large amount of data.
        // In structure we cannt Intialse fields. We can only intialise feilds in a construtor

        public int VehicleNo {  get; set; }
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }

        // In Structure we can't define Parameter less constructore Since there is already a default parameterless construtor Implicitly

        //Parameterised constructor

        public Vehicle(int vehicleNo, string vehicleName, string vehicleType)
        {
            VehicleNo = vehicleNo;
            VehicleName = vehicleName;
            VehicleType = vehicleType;
        }

        //Creating Method

        public string GetVehicleDetails()
        {
            var registrationYear = 2022;

            return "Vehicle is registered in an Year: " + registrationYear ;
        }

    }
}
