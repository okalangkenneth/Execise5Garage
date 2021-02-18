using System;

namespace Garage
{
    class Program
    {
        /// <summary>
        /// /The main entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[]args)
        {
            GarageHandler garageHandler = new GarageHandler();
            garageHandler.SetCapacity(10);
            int input = garageHandler.TextMenu();

            Console.Clear();

            garageHandler.MainMenu();

            Garage<Vehicle> garage = new Garage<Vehicle>(10);


            //var benz = new Car("Car");
            var volvo= new Car("Car","ABC123", "Black", 4, "Petrol", "Volvo");
            //var fiat = new Car();

            var Scania = new Bus("Bus","BUS111", "Red", 8, 20, "Electric");

            //var Misubishi = new Boat();

            //var Honda = new Motorcycle();

            //var RollsRoyce = new Airplane();
            
        }
    }

    
    
}
