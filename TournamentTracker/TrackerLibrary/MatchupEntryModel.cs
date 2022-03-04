namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        ///Represents One team in the Matchup 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /*
         Represents the score for this particular team
         */
        public double Score { get; set; }
        /*
         Represents the matchup that this team came
         from as the winner 
         */
        public MatchupModel ParentMatchup { get; set; }

    }
}