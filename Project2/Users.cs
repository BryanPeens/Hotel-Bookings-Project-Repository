using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Users
    {
        private string id;
        private string username;

        public Users(string id, string username)
        {
            Id = id;
            Username = username;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }

        public override string ToString()
        {
            return string.Format("{0},{1}",id, username);
        }
    }
}
