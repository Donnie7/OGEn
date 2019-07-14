using System;

namespace OGameEngine.Core.Interfaces
{
    public interface IUpgradable
    {
        void Upgrade();
        int GetLevel();
        bool ReadyToUpgrade();
        TimeSpan TimeLeftToFinishUpgrade();
    }
}
