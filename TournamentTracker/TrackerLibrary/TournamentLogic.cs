using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order the lists randomly
        // Check if it is big enough, if not, add byes - Teams to function properly 2*2*2*2 (2^n)
        // Create the first round of matchups
        // Create every round after that - Ex: 8 matchups - 4 matchups - 2 matchup - 1 matchup

        public static void CreateRounds(TournamentModel model)
        {
            // Order the lists randomly
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);

            // Check if it is big enough, if not, add byes - Teams to function properly 2*2*2*2 (2^n)
            int rounds = FindNumberOfRounds(randomizedTeams.Count());
            int byes = NumberOfByes(rounds, randomizedTeams.Count());

            // Create the first round of matchups
            model.Rounds.Add(CreateFirstRount(byes, randomizedTeams));

            // Create every round after that - Ex: 8 matchups - 4 matchups - 2 matchup - 1 matchup
            CreateOtherRounds(model, rounds);

        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel(); 
            while (round <= rounds)
            {
                foreach (MatchupModel matchup in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup });
                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;

            }
        }

        private static List<MatchupModel> CreateFirstRount(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();
                    if (byes >0)
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            
            // the number of teams in a round
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                // val = val *2
                val *= 2;

            }

            return output;

        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
