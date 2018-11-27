using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICreationBreakout.Models
{
    public class NintendoCharacters
    {
        public string Name { get; set; }
        public string GameSeries { get; set; }
        public int NumberOfGames { get; set; }
        public bool IsInSmashBros { get; set; }
        public NintendoCharacters()
        {

        }

        public NintendoCharacters(string Name, string GameSeries, int NumberOfGames, bool IsInSmashBros)
        {
            this.Name = Name;
            this.GameSeries = GameSeries;
            this.NumberOfGames = NumberOfGames;
            this.IsInSmashBros = IsInSmashBros;
        }
    }
}