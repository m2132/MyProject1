﻿using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        public Claim Add(int id, int RoleId, int PermissionId, EPolicys ePolicys)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Claim[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Claim GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Claim Update(Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}
