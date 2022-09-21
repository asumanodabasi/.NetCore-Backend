using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext> ,ICategoryDal
    {
       
    }
}
