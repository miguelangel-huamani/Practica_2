namespace Practica_2
{
    internal class Program
    {

        static void Main()
        {
            City Madrid = new City("Madrid");
            PoliceStation estacion_madrid = new PoliceStation("Estacion Madrid");

            Madrid.SetStation(estacion_madrid);

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");


            estacion_madrid.RegisterPoliceCar(policeCar1);
            estacion_madrid.RegisterPoliceCar(policeCar2);


            Madrid.RegisterTaxiLicense(taxi1);
            Madrid.RegisterTaxiLicense(taxi2);

            Madrid.ShowRegisteredTaxis();
            Console.WriteLine("     ");

            Madrid.RemoveTaxiLicense("0001 AAA");



            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine("     ");

            policeCar1.StartPatrolling();
            policeCar2.StartPatrolling();
            policeCar1.UseRadar(taxi1);






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


