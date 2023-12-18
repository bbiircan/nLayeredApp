using DataAccess.Concretes;
using DataAccess.Contexts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;

namespace DataAccess.Abstracts
{
    public interface IProductDal : IRepository<Product, int>, IAsyncRepository<Product,int> 
    {

    }
}
