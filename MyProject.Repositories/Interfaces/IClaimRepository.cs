using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        Claim[] GetAll();
        Claim GetById(int id);
        Claim Add(int id, int RoleId, int PermissionId, EPolicys ePolicys);
        Claim Update(Claim claim);
        void Delete(int id);
    }
}
