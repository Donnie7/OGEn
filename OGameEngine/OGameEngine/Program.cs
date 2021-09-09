using OGameEngine.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace OGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogame = new Ogame();
            ogame.Login();
            ogame.Resources.Navigate();
            var crystalMineLevel = ogame.Resources.CrystalMine.CurrentLevel;

            Console.WriteLine("You dont have messages");
        }


    }
}
