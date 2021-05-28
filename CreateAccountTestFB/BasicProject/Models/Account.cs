using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Models
{
    public class Account
    {
        public string Id { get; set; }
        public string Access_Token { get; set; }
        public string Login_Url { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string toString()
        {
            return this.Id + "|" + this.Access_Token + "|" + this.Email + "|" + this.Password + "|" + this.Login_Url;
        }
    }
}
