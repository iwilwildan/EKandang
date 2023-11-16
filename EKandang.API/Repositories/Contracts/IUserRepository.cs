using EKandang.API.Entities;
using EKandang.Models.Dtos;

namespace EKandang.API.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<User> SignUp(UserDto user);
        Task<User> SignIn(UserDto user);
    }
}
