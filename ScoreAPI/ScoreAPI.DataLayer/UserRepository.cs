using ScoreAPI.Models;

namespace ScoreAPI.DataLayer
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {

        }

        void IUserRepository.StoreUser(User user)
        {
            throw new NotImplementedException();
        }

        List<int> IUserRepository.GetScores(User user)
        {
            throw new NotImplementedException();
        }
    }
}