using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)  //Consturactor injection
        {
            _categoryDal = categoryDal; 
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuuccessDataResult<List<Category>>( _categoryDal.GetAll());
        }
        
        //Select*from Categories where CategoryId=3  =>alttaki kodun SQL karsiligi
        public  IDataResult<Category> GetById(int categoryId)
        {
            return new SuuccessDataResult<Category>( _categoryDal.Get(c => c.CategoryId == categoryId));   
        }
    }
}
