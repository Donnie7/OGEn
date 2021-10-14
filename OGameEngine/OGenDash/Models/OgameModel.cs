using System.Collections.Generic;

namespace OGenDash.Models
{
    public class OgameModel
    {

        public bool Connected { get; set; }
        public Researches Researches { get; set; }
        public IEnumerable<Planet> Planets { get; set; }

        public OgameModel()
        {
            Researches = new Researches();
            Planets = new List<Planet>();
        }
    }

    public class Planet
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Moon { get; set; }
    }

    public class Researches
    {
        public string EnergyLevel { get; set; }
        public string LaserLevel { get; set; }
        public string IonLevel { get; set; }
        public string HyperspaceLevel { get; set; }
        public string PlasmaLevel { get; set; }
        public string CombustionLevel { get; set; }
        public string ImpulsionLevel { get; set; }
        public string HyperspacePropulsionLevel { get; set; }
        public string SpyLevel { get; set; }
        public string ComputersLevel { get; set; }
        public string AstrophysicsLevel { get; set; }
        public string IntergalacticLevel { get; set; }
        public string GravitationLevel { get; set; }
        public string WeaponsLevel { get; set; }
        public string ShieldingLevel { get; set; }
        public string ArmorLevel { get; set; }
    }
}