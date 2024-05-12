using myFirstApi.DTOs;
using myFirstApi.Etities;

namespace myFirstApi.BLL
{
    public interface IUserService
    {
        void Add(UserToAddDto dto);
        void Update(UserToUpdateDto dto);
        void Delete(int userId);
        UserToGetDto Get(int userId);
        List<UserToGetDto> GetAll();
    }
}
