namespace OGameEngine
{
    public class Path
    {
        public class Login
        {
            public const string SessionTab = "//*[@id=\"loginRegisterTabs\"]/ul/li[1]/span";
            public const string UsernameForm = "//*[@id=\"loginForm\"]/div[1]/div/input";
            public const string PasswordForm = "//*[@id=\"loginForm\"]/div[2]/div/input";
            public const string LoginButton = "//*[@id=\"loginForm\"]/p/button[1]/span";
            public const string LastPlayedButton = "//*[@id=\"joinGame\"]/button";
        }

        public class Researches
        {
            public const string EnergyLevel = "//*[@id=\"technologies_basic\"]/ul/li[1]/span/span[1]/span[1] | //*[@id=\"technologies_basic\"]/ul/li[1]/span/span[2]/span[1]";
            public const string LaserLevel = "//*[@id=\"technologies_basic\"]/ul/li[2]/span/span[1]/span[1] | //*[@id=\"technologies_basic\"]/ul/li[2]/span/span[2]/span[1]";
            public const string IonLevel = "//*[@id=\"technologies_basic\"]/ul/li[3]/span/span[1]/span[1] | //*[@id=\"technologies_basic\"]/ul/li[3]/span/span[2]/span[1]";
            public const string HyperspaceLevel = "//*[@id=\"technologies_basic\"]/ul/li[4]/span/span[1]/span[1] | //*[@id=\"technologies_basic\"]/ul/li[4]/span/span[2]/span[1]";
            public const string PlasmaLevel = "//*[@id=\"technologies_basic\"]/ul/li[5]/span/span[1]/span[1] | //*[@id=\"technologies_basic\"]/ul/li[5]/span/span[2]/span[1]";
            public const string CombustionLevel = "//*[@id=\"technologies_drive\"]/ul/li[1]/span/span[1]/span[1] | //*[@id=\"technologies_drive\"]/ul/li[1]/span/span[2]/span[1]";
            public const string ImpulsionLevel = "//*[@id=\"technologies_drive\"]/ul/li[2]/span/span[1]/span[1] | //*[@id=\"technologies_drive\"]/ul/li[2]/span/span[2]/span[1]";
            public const string HyperspacePropulsionLevel = "//*[@id=\"technologies_drive\"]/ul/li[3]/span/span[1]/span[1] | //*[@id=\"technologies_drive\"]/ul/li[3]/span/span[2]/span[1]";
            public const string SpyLevel = "//*[@id=\"technologies_advanced\"]/ul/li[1]/span/span[1]/span[1] | //*[@id=\"technologies_advanced\"]/ul/li[1]/span/span[2]/span[1]";
            public const string ComputersLevel = "//*[@id=\"technologies_advanced\"]/ul/li[2]/span/span[1]/span[1] | //*[@id=\"technologies_advanced\"]/ul/li[2]/span/span[2]/span[1]";
            public const string AstrophysicsLevel = "//*[@id=\"technologies_advanced\"]/ul/li[3]/span/span[1]/span[1] | //*[@id=\"technologies_advanced\"]/ul/li[3]/span/span[2]/span[1]";
            public const string IntergalacticLevel = "//*[@id=\"technologies_advanced\"]/ul/li[4]/span/span[1]/span[1] | //*[@id=\"technologies_advanced\"]/ul/li[4]/span/span[2]/span[1]";
            public const string GravitationLevel = "//*[@id=\"technologies_advanced\"]/ul/li[5]/span/span[1]/span[1] | //*[@id=\"technologies_advanced\"]/ul/li[5]/span/span[2]/span[1]";
            public const string WeaponsLevel = "//*[@id=\"technologies_combat\"]/ul/li[1]/span/span[1]/span[1] | //*[@id=\"technologies_combat\"]/ul/li[1]/span/span[2]/span[1]";
            public const string ShieldingLevel = "//*[@id=\"technologies_combat\"]/ul/li[2]/span/span[1]/span[1] | //*[@id=\"technologies_combat\"]/ul/li[2]/span/span[2]/span[1]";
            public const string ArmorLevel = "//*[@id=\"technologies_combat\"]/ul/li[3]/span/span[1]/span[1] | //*[@id=\"technologies_combat\"]/ul/li[3]/span/span[2]/span[1]";
        }
    }
}
