<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using API.Entities;
using API.Controllers;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Collections.Generic;
using System;
=======
using System;
using System.Collections.Generic;
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

<<<<<<< HEAD
        //public int GetAge()
        //{
        //    return DateOfBirth.CalculateAge();
        //}
=======
        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9

    }
}