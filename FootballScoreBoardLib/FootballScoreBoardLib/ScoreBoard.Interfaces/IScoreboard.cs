using System.Collections.Generic;
using FootballScoreBoardLib.Interfaces;

namespace ScoreboardLibrary.Interfaces
{
    public interface IScoreboard
    {
        void StartMatch(string homeTeam, string awayTeam);
        void UpdateScore(string homeTeam, string awayTeam, int homeScore, int awayScore);
        void FinishMatch(string homeTeam, string awayTeam);
        IEnumerable<IMatch> GetMatchesInProgressOrderedByScore();
    }
}