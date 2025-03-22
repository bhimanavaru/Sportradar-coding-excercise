namespace FootballScoreBoardLib.Interfaces
{
    public interface IMatch
    {
        string HomeTeam { get; }
        string AwayTeam { get; }
        int HomeScore { get; }
        int AwayScore { get; }
        bool IsInProgress { get; }
        void UpdateScore(int homeScore, int awayScore);
        void FinishMatch();
    }
}