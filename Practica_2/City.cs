using System.Diagnostics.Metrics;
using static System.Collections.Specialized.BitVector32;

namespace Practica_2
{
    class City
    {
        private string Name;
        public List<PoliceStation> policeStations { get; private set; }
        public List<Taxi> RegisteredTaxis { get; private set; }

        public City(string name)
        {
            Name = name;
            RegisteredTaxis = new List<Taxi>();
            policeStations = new List<PoliceStation>();
        }

        public void SetStation(PoliceStation p)
        {
            policeStations.Add(p);
            Console.WriteLine($"Police station {p.GetName()} registered in {Name}.");
            p.SetCity(this);

        }

        public void RegisterTaxiLicense(Taxi taxi)
        {
            RegisteredTaxis.Add(taxi);
            Console.WriteLine($"Taxi with plate {taxi.GetPlate()} registered in {Name}.");
            taxi.SetCity(this);
        }

        public void RemoveTaxiLicense(string plate)
        {
            Taxi? taxiToRemove = RegisteredTaxis.Find(taxi => taxi.GetPlate() == plate);

            if (taxiToRemove != null)
            {
                RegisteredTaxis.Remove(taxiToRemove);
                Console.WriteLine($"Taxi with plate {plate} license has been removed.");
                taxiToRemove.SetCity(null);

            }
            else
            {
                Console.WriteLine($"Taxi with plate {plate} not found.");
            }
        }

        public void ShowRegisteredTaxis()
        {
            Console.WriteLine($"Taxis registered in {Name}:");
            foreach (Taxi taxi in RegisteredTaxis)
            {
                Console.WriteLine(taxi.GetPlate());
            }
        }

        public string GetName()
        {
            return Name;
        }
        

    }
}

