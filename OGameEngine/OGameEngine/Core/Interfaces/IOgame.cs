namespace OGameEngine.Core.Interfaces
{
    public interface IOgame
    {
        bool Connected { get; set; }
        Researches Researches { get; set; }
    }
}