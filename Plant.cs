using System;

namespace partythyme
{
    public class Plant
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string LocatedPlanted { get; set; }
        public DateTime PlantedDate { get; set; }
        public DateTime LastWateredDate { get; set; }
        public string LightNeeded { get; set; }
        public string WaterNeeded { get; set; }
    }
}