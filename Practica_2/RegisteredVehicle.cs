namespace Practica_2
{
    abstract class RegisteredVehicle : Vehicle
    {
        protected string plate;

        protected RegisteredVehicle(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.plate = plate;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public override string GetPlate()
        {
            return plate;
        }
    }
}