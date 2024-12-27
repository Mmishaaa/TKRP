using AutoMapper;
using SportComplex.BLL.Interfaces;
using SportComplex.BLL.Models;
using SportComplex.DAL.Entities;
using SportComplex.DAL.Interfaces;

namespace SportComplex.BLL.Services
{
    public class UserService : GenericService<UserModel, UserEntity>, IUserService
    {
        public UserService(IUserRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

    }
}
