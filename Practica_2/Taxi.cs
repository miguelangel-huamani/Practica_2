namespace Practica_2
{
    class Taxi : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances.
        private static string typeOfVehicle = "Taxi";
        private bool isCarryingPassengers;
        private City? city;

        public Taxi(string plate) : base(typeOfVehicle, plate)
        {
            //Values of atributes are set just when the instance is done if not needed before.
            isCarryingPassengers = false;
            SetSpeed(45.0f);
        }

        public void SetCity(City? c)
        {
            city = c;

            if (c == null)
            {
                Console.WriteLine($"Taxi with plate {GetPlate()} unregistered from any city.");
            }
            else
            {
                Console.WriteLine($"Taxi registered in {c.GetName()}.");
            }
        }

        public void StartRide()
        {
            if (!isCarryingPassengers)
            {
                isCarryingPassengers = true;
                SetSpeed(100.0f);
                Console.WriteLine(WriteMessage("starts a ride."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already in a ride."));
            }
        }

        public void StopRide()
        {
            if (isCarryingPassengers)
            {
                isCarryingPassengers = false;
                SetSpeed(45.0f);
                Console.WriteLine(WriteMessage("finishes ride."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is not on a ride."));
            }
        }
    }
}