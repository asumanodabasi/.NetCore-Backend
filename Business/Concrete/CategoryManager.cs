using Business.Abstract;
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

        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDal.GetAll();
        }
        
        //Select*from Categories where CategoryId=3  =>alttaki kodun SQL karsiligi
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);   
        }
    }
}
