using myFirstApi.DAL.Repositories;
using myFirstApi.Etities;

namespace myFirstApi.DAL.UseCases
{
    public class RoleReprository(AppDbContext context) : IRoleRepository
    {
        private readonly AppDbContext _context = context;
        public void Add(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void Delete(int roleId)
        {
            var role = _context.Roles.FirstOrDefault(x => x.Id == roleId);
            _context.Remove(role);
            _context.SaveChanges();
        }

        public Role Get(int roleId)
        {
            var role = _context.Roles.Find(roleId);
            return role;
        }

        public List<Role> GetAll()
        {
            var roles = _context.Roles.ToList();
            return roles;
        }

        public void Update(Role role)
        {
            var data = _context.Roles.Find(role.Id);
            _context.Roles.Update(data);
            _context.SaveChanges();
        }
    }
}
