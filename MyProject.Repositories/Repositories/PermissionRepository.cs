using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        public Permission Add(int id, string name, string description)
        {
            throw new NotImplementedException();
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
    }
}
