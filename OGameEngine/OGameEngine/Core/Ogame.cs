﻿using OGameEngine.Webdriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OGameEngine.Core.Interfaces;

namespace OGameEngine.Core
{
    public class Ogame : IOgame
    {
        public bool Connected { get; set; }
        public Researches Researches { get; set; }
        public IEnumerable<Planet> Planets { get; set; }
        public Resources Resources;
        public Facilities Facilities;
        public Shipyard Shipyard;
        public Defense Defense;
        public Fleet Fleet;
        public Galaxy Galaxy;

        public Ogame()
        {
            Connected = false;
            Planets = new List<Planet>();
            Resources = new Resources();
            Facilities = new Facilities();
            Researches = new Researches();
            Shipyard = new Shipyard();
            Defense = new Defense();
            Fleet = new Fleet();
            Galaxy = new Galaxy();
        }
    }
}
