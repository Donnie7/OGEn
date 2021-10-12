namespace OGameEngine.Webdriver
{
    public class Researches : IResearches
    {
        private readonly IDriver driver;
        
        public Researches(IDriver driver)
        {
            this.driver = driver;
        }

        public string GetEnergyLevel() => driver.GetValue(Path.Researches.EnergyLevel); 

        public string GetLaserLevel() => driver.GetValue(Path.Researches.LaserLevel);

        public string GetIonLevel() => driver.GetValue(Path.Researches.IonLevel);

        public string GetHyperspaceLevel() => driver.GetValue(Path.Researches.HyperspaceLevel);

        public string GetPlasmaLevel() => driver.GetValue(Path.Researches.PlasmaLevel);

        public string GetCombustionLevel() => driver.GetValue(Path.Researches.CombustionLevel);

        public string GetImpulsionLevel() => driver.GetValue(Path.Researches.ImpulsionLevel);

        public string GetHyperspacePropulsionLevel() => driver.GetValue(Path.Researches.HyperspacePropulsionLevel);

        public string GetSpyLevel() => driver.GetValue(Path.Researches.SpyLevel);

        public string GetComputersLevel() => driver.GetValue(Path.Researches.ComputersLevel);

        public string GetAstrophysicsLevel() => driver.GetValue(Path.Researches.AstrophysicsLevel);

        public string GetIntergalacticLevel() => driver.GetValue(Path.Researches.IntergalacticLevel);

        public string GetGravitationLevel() => driver.GetValue(Path.Researches.GravitationLevel);

        public string GetWeaponsLevel() => driver.GetValue(Path.Researches.WeaponsLevel);

        public string GetShieldingLevel() => driver.GetValue(Path.Researches.ShieldingLevel);

        public string GetArmorLevel() => driver.GetValue(Path.Researches.ArmorLevel);
    }

    public interface IResearches
    {
        string GetEnergyLevel();
        string GetLaserLevel();
        string GetIonLevel();
        string GetHyperspaceLevel();
        string GetPlasmaLevel();
        string GetCombustionLevel();
        string GetImpulsionLevel();
        string GetHyperspacePropulsionLevel();
        string GetSpyLevel();
        string GetComputersLevel();
        string GetAstrophysicsLevel();
        string GetIntergalacticLevel();
        string GetGravitationLevel();
        string GetWeaponsLevel();
        string GetShieldingLevel();
        string GetArmorLevel();
        
    }
}