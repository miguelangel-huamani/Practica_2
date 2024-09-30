using System;
namespace Practica_2
{
	abstract class UnRegisteredVehicle : Vehicle
	{
        protected UnRegisteredVehicle(string typeOfVehicle) : base(typeOfVehicle) { }

        public override string GetPlate()
        {
            return "Vehicle has no plate"; 
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} (unregistered)";
        }
    }
}

