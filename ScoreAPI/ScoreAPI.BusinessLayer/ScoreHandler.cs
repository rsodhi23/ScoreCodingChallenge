using ScoreAPI.Models;

namespace ScoreAPI.BusinessLayer
{
    public class  ScoreHandler : IScoreHandler
    {
        public ScoreHandler()
        {

        }

        public int CalculateScore(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                return 0;
            } else
            {
                return 1;
            }
        }
    }
}
