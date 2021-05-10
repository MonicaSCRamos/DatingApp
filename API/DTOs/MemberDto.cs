using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class MemberDto
    {
<<<<<<< HEAD
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl { get; set; }
    
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; } 
        public string Gender { get; set; }
        public string Introduction { get; set; }
=======
       public int Id { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
<<<<<<< HEAD
        public ICollection<PhotoDto> Photos { get; set; }
=======
        public ICollection<PhotoDto> Photos { get; set; } 
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
    }
}