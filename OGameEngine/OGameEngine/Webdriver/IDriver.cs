using System.Collections.Generic;
using OGameEngine.Core;

namespace OGameEngine.Webdriver
{
    public interface IDriver
    {
        bool ConnectToOgame();
        void GoTo(string url);

        string GetValue(string xpath);

        IResearches Researches { get; }

        IEnumerable<Planet> GetPlanets();
    }
}