using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        //6.1.2023.
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();
    }
}
