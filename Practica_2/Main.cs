using System.Diagnostics.Metrics;

namespace Practica_2
{
    internal class Program
    {

        static void Main()

        {   //Creación de la ciudad
            City Madrid = new City("Madrid");
            Console.WriteLine(Madrid.WriteMessage("Created"));
            Console.WriteLine("     ");

            //Creación de la comisaria de policia
            PoliceStation estacion = new PoliceStation("Estación Central");
            Console.WriteLine(estacion.WriteMessage("Created"));
            Madrid.SetStation(estacion);
            Console.WriteLine("     ");

            //Creación de un scooter aunque no lo piden
            Scooter scooter1 = new Scooter();
            Console.WriteLine(scooter1.WriteMessage("Created"));

            //Creación de los taxis
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));

            //Registro de varios taxis en la ciudad
            Madrid.RegisterTaxiLicense(taxi1);
            Madrid.RegisterTaxiLicense(taxi2);
            Madrid.ShowRegisteredTaxis();
            Console.WriteLine("     ");

            //Creación de los coches policía
            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));

            //Creación de los radares
            SpeedRadar radar1 = new SpeedRadar();
            SpeedRadar radar2 = new SpeedRadar();
            Console.WriteLine("Two radars have been created");

            policeCar2.SetRadar(radar2);
            Console.WriteLine("     ");

            //Rgeistro de los coches de policía en la comisaría (policeCar1 tiene radar, policeCar2 no)
            estacion.RegisterPoliceCar(policeCar1);
            estacion.RegisterPoliceCar(policeCar2);

            //El primer coche de policía empieza a patrullar 
            policeCar1.StartPatrolling();
            Console.WriteLine("     ");

            //Coche sin radar intenta utilizar el radar
            policeCar1.UseRadar(taxi1);
            taxi2.StartRide();
            Console.WriteLine("     ");

            //Extra: Verificamos que se pueda usar el radar de forma individual
            radar1.TriggerRadar(taxi1);
            string measurement1 = radar1.GetLastReading();
            Console.WriteLine($"Triggered individual radar. Result: {measurement1}");
            Console.WriteLine("     ");


            //Coche con radar intenta utilizar el radar (sin exito)
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();

            //Ya con el coche en marcha y con el radar en él se detecta (con exito) un vehículo sobrepasando los límites de velocidad y empieza a perseguirlo junto con el resto de coches patrullando
            policeCar2.UseRadar(taxi2);
            Console.WriteLine("     ");

            //Obtenemos mediante get la matrícula del coche infractor y le retiramos la licencia
            string infractor_plate = policeCar2.GetInfractorPlate();
            Madrid.RemoveTaxiLicense(infractor_plate);
            Console.WriteLine("     ");

            // Los taxis terminan de llevar gente y los policías de patrullar
            
            policeCar1.EndPatrolling();
            policeCar2.EndPatrolling();
            Console.WriteLine("     ");

            //El coche de policía no tendrá este historial ya que no tenía radar
            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
            

        }
    }
}


