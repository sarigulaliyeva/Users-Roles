using myFirstApi.Etities;

namespace myFirstApi.DAL.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
        User Get(int userId);
        List<User> GetAll();
    }
}
