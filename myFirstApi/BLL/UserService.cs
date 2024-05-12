using AutoMapper;
using myFirstApi.DAL;
using myFirstApi.DAL.Repositories;
using myFirstApi.DTOs;
using myFirstApi.Etities;

namespace myFirstApi.BLL
{
    public class UserService(IMapper mapper, IUserRepository repository) : IUserService
    {
        private readonly IMapper _mapper=mapper;
        private readonly IUserRepository _repository =repository;
        public void Add(UserToAddDto dto)
        {
            var user = _mapper.Map<User>(dto);
            _repository.Add(user);
        }

        public void Delete(int userId)
        {
            _repository.Delete(userId);
        }

        public UserToGetDto Get(int userId)
        {
            var user = _repository.Get(userId);
            return _mapper.Map<UserToGetDto>(user);
        }

        public List<UserToGetDto> GetAll()
        {
            var users = _repository.GetAll();
            return _mapper.Map<List<UserToGetDto>>(users);  
        }

        public void Update(UserToUpdateDto dto)
        {
            var user = _repository.Get(dto.Id);
            var entity = _mapper.Map<User>(dto);
            _repository.Update(entity);
        }
    }
}
