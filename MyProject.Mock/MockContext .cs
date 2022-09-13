using MyProject.Repositories;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;

namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Permission { get; set; }
        public List<Permission> Permissions { get; set; }
        public List<Claim> Claims { get; set; }
        public List<Role> Roles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MockContext()
        {
            this.Permission = new List<Role>();
            this.Permissions = new List<Permission>();
            this.Claims = new List<Claim>();

            this.Permission.Add(new Role { Id = 1, Name = "admin", Description = "administrator with full access" });
            this.Permission.Add(new Role { Id = 2, Name = "user", Description = "user with limited access" });

            this.Permissions.Add(new Permission { Id = 1, Name = "VIEW_ALL_ORDERS" });
            this.Permissions.Add(new Permission { Id = 2, Name = "VIEW_ALL_PRODUCTS" });

            this.Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, ePolicy = EPolicys.Allow });
            this.Claims.Add(new Claim { Id = 2, RoleId = 2, PermissionId = 1, ePolicy = EPolicys.Deny });
            this.Claims.Add(new Claim { Id = 3, RoleId = 1, PermissionId = 2, ePolicy = EPolicys.Allow });
           this.Claims.Add(new Claim { Id = 4, RoleId = 2, PermissionId = 2, ePolicy = EPolicys.Allow });
        }
    }
}
