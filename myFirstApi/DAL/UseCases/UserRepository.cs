using Microsoft.EntityFrameworkCore;
using myFirstApi.DAL.Repositories;
using myFirstApi.Etities;

namespace myFirstApi.DAL.UseCases
{
    public class UserRepository(AppDbContext context) : IUserRepository
    {
        private readonly AppDbContext _context=context;
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);
            _context.Remove(user);
            _context.SaveChanges() ;
        }

        public User Get(int userId)
        {
            var user = _context.Users.Find(userId);
            return user;
        }

        public List<User> GetAll()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public void Update(User user)
        {
            var data = _context.Users.Find(user.Id);
            _context.Users.Update(data);
            _context.SaveChanges();
        }
    }
}
