using Domain.Entities;
using Application.Interface.Repository.Core;
using Application.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IGenericRepository<Product> _repository;

        public ProductRepository(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }
    }
}
