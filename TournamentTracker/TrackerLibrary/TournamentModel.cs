using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams = new List<TeamModel>();
        public List<PrizeModel> Prizes = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds = new List<List<MatchupModel>>();

        public TournamentModel()
        {
        }
    }
}
