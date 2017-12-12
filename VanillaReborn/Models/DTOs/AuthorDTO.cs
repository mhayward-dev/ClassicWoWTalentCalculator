using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanillaReborn.Models.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string AvatarImage { get; set; }

        public static AuthorDTO ToDTO(Author a)
        {
            return new AuthorDTO
            {
                Id = a.Id,
                Name = a.Name,
                RoleName = a.RoleName,
                AvatarImage = $"/images/avatars/{a.AvatarImage}"
            };
        }
    }
}
