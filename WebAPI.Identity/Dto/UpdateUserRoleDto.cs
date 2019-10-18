using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Identity.Dto
{
    public class UpdateUserRoleDto
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Delete { get; set; }
    }
}
