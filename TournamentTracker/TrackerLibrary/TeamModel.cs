using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the list of Team Members and the Team Name.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Unique identifier for the Team.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// List of Team members that are apart of this Team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Name of the Team.
        /// </summary>
        public string TeamName { get; set; }


    }
}
