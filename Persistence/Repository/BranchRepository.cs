using Domain.Entities;
using Application.Interface.Repository.Core;
using Application.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly IGenericRepository<Branch> _repository;

        public BranchRepository(IGenericRepository<Branch> repository)
        {
            _repository = repository;
        }
    }
}
