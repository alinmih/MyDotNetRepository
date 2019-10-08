using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents the tournament model
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The unique Id identifier for the tournament
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the tournament name
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the enry fee for every team
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the set of teams entered in this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of prizes for current tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the set of matchups in the total number of rounds 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
