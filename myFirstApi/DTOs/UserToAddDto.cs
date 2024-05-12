using myFirstApi.Etities;

namespace myFirstApi.DTOs
{
    public class UserToAddDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
