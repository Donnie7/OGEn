namespace Domain
{
    using System.Collections.Generic;

    public class Account
    {
        public string Name { get; }
        public IEnumerable<Planet> Planets { get; }
        public Research Research { get; }
        public Alliance Alliance { get; }
    }
}