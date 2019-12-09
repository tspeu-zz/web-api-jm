using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jm_web_api.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
    }
}
