using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //interface'in oparasyonları default publicdir. ama kendisi default public değildir.
       
    }
}
