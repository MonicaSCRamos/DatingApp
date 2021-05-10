using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
<<<<<<< HEAD
        Task<IEnumerable<MemberDto>> GetMemberAsync();
=======
        Task<IEnumerable<MemberDto>> GetMembersAsync();
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
        Task<MemberDto> GetMemberAsync(string username);
    }
}