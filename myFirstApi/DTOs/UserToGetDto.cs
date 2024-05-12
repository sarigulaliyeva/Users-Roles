using myFirstApi.Etities;

namespace myFirstApi.DTOs
{
    public class UserToGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public RoleDto Role { get; set; }
    }
}
