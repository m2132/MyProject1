using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;

        public RoleRepository(IContext context)
        {
            _context = context;
        }
        public Role Add(int id, string name, string description)
        {
            var newRole = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(newRole);
            return newRole;
        }

        public void Delete(int id)
        {
          var deleteRole=_context.Roles.Find(r => r.Id == id);
            if(deleteRole!=null)
            _context.Roles.Remove(deleteRole);
    
        }
        public Role GetById(int id)
        {
            return _context.Roles.Find(r => r.Id == id);
        }

        public Role Update(Role role)
        {
            //var newRole = GetById(role.id);לשאול מה עדיף
            var updateRole= _context.Roles.Find(r => r.Id == role.id);
            updateRole.Name = role.Name;
            updateRole.Description = role.Description;         
            return updateRole;
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }
    }
}
