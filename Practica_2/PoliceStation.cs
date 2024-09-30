
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using static System.Collections.Specialized.BitVector32;

namespace Practica_2
{
	class PoliceStation
	{
        public string Name;
        public List<PoliceCar> PoliceCars { get; private set; }
		private bool AlertActive;
		private City? city;


        public PoliceStation(string name)
		{
			Name = name;
			PoliceCars = new List<PoliceCar>();
			AlertActive = false;

		}

		public void RegisterPoliceCar(PoliceCar policeCar)
        {
			PoliceCars.Add(policeCar);
            Console.WriteLine($"Police car with plate {policeCar.GetPlate()} register in police station {Name}.");
			policeCar.SetStation(this);

        }

        public void SetCity(City c)
        {
            city = c;
        }

        public void ActivateAlert(string plate)
		{

			Console.WriteLine("ALARM ACTIVATED!!!!!");
			AlertActive = true;

            foreach (PoliceCar policeCar in PoliceCars)
            {
                policeCar.SetInfractorPlate(plate);
            }

        }






	}
}

