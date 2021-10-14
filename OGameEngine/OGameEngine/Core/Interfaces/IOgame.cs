using System.Collections.Generic;

namespace OGameEngine.Core.Interfaces
{
    public interface IOgame
    {
        bool Connected { get; set; }
        Researches Researches { get; set; }
        
        IEnumerable<Planet> Planets { get; set; }
    }
}