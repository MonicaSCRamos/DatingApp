using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
<<<<<<< HEAD
using API.Interfaces;
using API.DTOs;
using AutoMapper;
=======
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
<<<<<<< HEAD
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
=======
         private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
             _mapper = mapper;
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
            _userRepository = userRepository;
        }

        [HttpGet]
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMemberAsync();
=======
          public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
                  var users = await _userRepository.GetMembersAsync();
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9

            return Ok(users);
        }

<<<<<<< HEAD
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return await _userRepository.GetMemberAsync(username);
=======
     [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
        return await _userRepository.GetMemberAsync(username);
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
        }
    }
} 
