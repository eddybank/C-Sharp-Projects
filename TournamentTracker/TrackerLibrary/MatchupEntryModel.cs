using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Team of a Matchup.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Unique identifier for the Matchup Entry.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// One Team competing in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The score for this particular Team in a Matchup.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The matchup that this team came
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
