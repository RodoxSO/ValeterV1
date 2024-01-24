using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valeter.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; } = string.Empty;
        
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}