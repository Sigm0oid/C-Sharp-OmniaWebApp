﻿using MyData.Infrastructure;
using MyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Repositories
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface IServiceRepository : IRepository<Service>
    {

    }
}
