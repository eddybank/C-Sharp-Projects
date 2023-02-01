using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a list of MatchupEntry's, the Winner of the Matchup and the Round the Matchup.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Unique identifier for a Matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// List of Matchup Entries in the Matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The winner of the Matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The round that this Matchup is apart of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
