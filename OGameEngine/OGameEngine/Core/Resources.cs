using OGameEngine.Core.ResourceBuildings;
using OGameEngine.Webdriver;

namespace OGameEngine.Core
{
    public class Resources
    {
        public MetalMine MetalMine;
        public CrystalMine CrystalMine;
        public DeuteriumMine DeuteriumMine;
        public PowerPlant PowerPlant;
        public FusionPlant FusionPlant;
        public SolarSatelite SolarSatelite;
        public MetalSilo MetalSilo;
        public CrystalSilo CrystalSilo;
        public DeuteriumSilo DeuteriumSilo;

        public Resources()
        {
            MetalMine = new MetalMine();
            CrystalMine = new CrystalMine();
            DeuteriumMine = new DeuteriumMine();
            PowerPlant = new PowerPlant();
            FusionPlant = new FusionPlant();
            SolarSatelite = new SolarSatelite();
            MetalSilo = new MetalSilo();
            CrystalSilo = new CrystalSilo();
            DeuteriumSilo = new DeuteriumSilo();
        }

        public void Navigate()
        {
         
        }
    }
}
