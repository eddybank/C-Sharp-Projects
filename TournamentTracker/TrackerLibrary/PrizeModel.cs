using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a Prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the Prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Place number for a Prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the Prize.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The amount of the Prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of total money allocated all the Prize.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel() 
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            int prizePercentageValue = 0;
            int.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
