using ScoreAPI.Models;

namespace ScoreAPI.DataLayer
{
    public interface IUserRepository
    {
        void StoreUser(User user);
        List<int> GetScores(User user);
    }
}