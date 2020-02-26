using System;
using System.Linq;

namespace partythyme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to a database
            var db = new GardenContext();

            //Create new plant
            db.Plants.Add(new Plant
            {
                Species = "Tomato",
                LocatedPlanted = "Bin 1",
                PlantedDate = new DateTime(2019, 12, 20),
                LastWateredDate = new DateTime(2020, 2, 25),
                LightNeeded = "High",
                WaterNeeded = "High"
            });
            db.Plants.Add(new Plant
            {
                Species = "Lettuce",
                LocatedPlanted = "Bin 2",
                PlantedDate = new DateTime(2019, 12, 30),
                LastWateredDate = new DateTime(2020, 2, 24),
                LightNeeded = "Medium",
                WaterNeeded = "Medium"
            });
            db.Plants.Add(new Plant
            {
                Species = "Cucumber",
                LocatedPlanted = "Bin 3",
                PlantedDate = new DateTime(2020, 1, 2),
                LastWateredDate = new DateTime(2020, 2, 24),
                LightNeeded = "Medium",
                WaterNeeded = "Medium"
            });
            db.Plants.Add(new Plant
            {
                Species = "Chili",
                LocatedPlanted = "Bin 4",
                PlantedDate = new DateTime(2020, 1, 10),
                LastWateredDate = new DateTime(2020, 2, 22),
                LightNeeded = "Low",
                WaterNeeded = "Low"
            });
            db.Plants.Add(new Plant
            {
                Species = "Carrot",
                LocatedPlanted = "Bin 5",
                PlantedDate = new DateTime(2020, 1, 30),
                LastWateredDate = new DateTime(2020, 2, 25),
                LightNeeded = "Low",
                WaterNeeded = "Low"
            });
            db.SaveChanges();

            Console.WriteLine("what would you like to do?");
            Console.WriteLine("VIEW PLANTS,PLANT NEW PLANT, REMOVE A PLANT, WATER A PLANT, VIEW PLANTS THAT HAVEN'T BEEN WATERED, LOCATION SUMMARY, QUIT");
            var input = Console.ReadLine().ToLower();

            var isRunning = true;
            while (isRunning)
            {
                if (input == "View plants")
                {
                    var viewPlants = db.Plants.Where(Plants => Plants.Id > 0);
                }
                else if (input == "remove a plant")
                {
                    Console.WriteLine("who?");
                    var plantToRemove = Console.ReadLine();
                    var plant = db.Plants.First(Plants => Plants.Species == plantToRemove);
                }
                else if (input == "water a plant")
                {
                    Console.WriteLine("What plant do you want to water?");
                    var plantToWater = Console.ReadLine();
                    var waterNewPlant = db.Plants.First(Plant => Plant.Species == plantToWater);
                }
                else if (input == "view pants that haven't been watered")
                {
                    var viewWateredPlants = db.Plants.Where(Plants => Plants.LastWateredDate != DateTime.Now);
                }
                else if (input == "quit")
                {
                    isRunning = false;
                }
            }
        }
    }
}
