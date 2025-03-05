using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roles
{
    class user
    {
        public int UserId { get; set; }
        public int UserName { get; set; }
        public int RoleId { get; set; }
    }
    class role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string AutherizedId { get; set; }
    }
    class autherization
    {
        public int AutherizedId { get; set; }
        public List<string> Permission{ get; set; }
       
    }
    class admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
    
    }
    
}
