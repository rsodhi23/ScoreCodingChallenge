using ScoreAPI.Models;

namespace ScoreAPI.BusinessLayer
{
    public interface  IScoreHandler
    {
        int CalculateScore(User user);
    }
}
