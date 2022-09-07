using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Role[] GetAll();
        Role GetById(int id);
        Role Add(int id, string name, string description);
        Role Update(Role role);
        void Delete(int id);
    }
}
