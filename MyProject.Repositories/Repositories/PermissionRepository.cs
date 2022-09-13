using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context;

        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(int id, string name, string description)
        {
            var newPermission = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(newPermission);
            return newPermission;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Permission[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Permission GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Permission Update(Permission permission)
        {
            throw new NotImplementedException();
        }

        List<Permission> IPermissionRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
