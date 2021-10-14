using System.Linq;
using OGameEngine.Core.Interfaces;

namespace OGenDash.Models
{
    public static class Extensions
    {
        public static OgameModel ToModel(this IOgame ogame)
        {
            return new OgameModel
            {
                Connected = ogame.Connected,
                Researches = new Researches
                {
                    EnergyLevel = ogame.Researches.EnergyLevel,
                    LaserLevel = ogame.Researches.LaserLevel,
                    IonLevel = ogame.Researches.IonLevel,
                    HyperspaceLevel = ogame.Researches.HyperspaceLevel,
                    PlasmaLevel = ogame.Researches.PlasmaLevel,
                    CombustionLevel = ogame.Researches.CombustionLevel,
                    ImpulsionLevel = ogame.Researches.ImpulsionLevel,
                    HyperspacePropulsionLevel = ogame.Researches.HyperspacePropulsionLevel,
                    SpyLevel = ogame.Researches.SpyLevel,
                    ComputersLevel = ogame.Researches.ComputersLevel,
                    AstrophysicsLevel = ogame.Researches.AstrophysicsLevel,
                    IntergalacticLevel = ogame.Researches.IntergalacticLevel,
                    GravitationLevel = ogame.Researches.GravitationLevel,
                    WeaponsLevel = ogame.Researches.WeaponsLevel,
                    ShieldingLevel = ogame.Researches.ShieldingLevel,
                    ArmorLevel = ogame.Researches.ArmorLevel
                },
                Planets = ogame.Planets.Select(x => new Planet{ Name = x.Name, Location = x.Location })
            };
        }
    }
}