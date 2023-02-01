using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a Tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Unique identifier for the Tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the Tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Entry fee for the Tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of Teams entered into a Tournament.
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes for a Tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of the List of Matchups (2-Dimensional List).
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
