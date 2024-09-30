namespace Practica_2
{
    internal class Program
    {

        static void Main()

        {
            City Madrid = new City("Madrid");
            Console.WriteLine(Madrid.WriteMessage("has been created"));

            PoliceStation estacion = new PoliceStation("Estación Central");
            Console.WriteLine(estacion.WriteMessage("has been created"));

            Madrid.SetStation(estacion);

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));

            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));


            Scooter scooter1 = new Scooter();
            Console.WriteLine(scooter1.WriteMessage("Created"));


            SpeedRadar radar1 = new SpeedRadar();
            SpeedRadar radar2 = new SpeedRadar();

            estacion.RegisterPoliceCar(policeCar1);
            estacion.RegisterPoliceCar(policeCar2);

            Madrid.RegisterTaxiLicense(taxi1);
            Madrid.RegisterTaxiLicense(taxi2);

            Madrid.ShowRegisteredTaxis();
            Console.WriteLine("     ");


            radar1.TriggerRadar(taxi2);
            string measurement1 = radar1.GetLastReading();
            Console.WriteLine($"Triggered individual radar. Result: {measurement1}");

            Madrid.RemoveTaxiLicense("0001 AAA");
          
            Console.WriteLine("     ");

            policeCar1.StartPatrolling();
            policeCar2.StartPatrolling();


            policeCar1.UseRadar(taxi2);
            policeCar2.SetRadar(radar2);
            policeCar2.UseRadar(taxi2);



              
            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
            

        }
    }
}


