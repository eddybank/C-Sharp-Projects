using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Team Member.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Unique identifier for a Person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// First Name of a Team Member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of a Team member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email Address of a Team member.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Cell Phone Number of a Team member.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
