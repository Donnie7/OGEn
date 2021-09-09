using OGameEngine.Core.Interfaces;
using OGameEngine.Webdriver;
using System;

namespace OGameEngine.Core
{
    public class UpgradableBuilding : IUpgradable
    {
        public int CurrentLevel;
        public bool ReadyToUpgrade;
        public TimeSpan TimeLeftToFinishUpgrade;

        public void UpdateValues()
        {
            // UpdateLevel
            throw new System.NotImplementedException();
        }

        public void Upgrade()
        {
            throw new System.NotImplementedException();
        }
    }
}