using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchUpRound { get; set; }

    }
}