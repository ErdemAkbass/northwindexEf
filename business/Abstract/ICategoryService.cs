using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace business.Abstract
{
    interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
