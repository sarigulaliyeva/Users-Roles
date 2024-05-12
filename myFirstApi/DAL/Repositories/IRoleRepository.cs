using myFirstApi.Etities;

namespace myFirstApi.DAL.Repositories
{
    public interface IRoleRepository
    {
        void Add(Role role);
        void Update(Role role);
        void Delete(int roleId);
        Role Get(int roleId);
        List<Role> GetAll();
    }
}
