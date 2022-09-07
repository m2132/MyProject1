using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories
{
    public enum EPolicys
    {
        Allow = 1,
        Deny = 2,
    }
    public class Claim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public EPolicys ePolicy { get; set; }
    }

}
