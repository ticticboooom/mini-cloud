using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.Main.DataAccess.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
    }
}
