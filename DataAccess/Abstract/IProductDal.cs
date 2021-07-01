using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //interface'in oparasyonları default publicdir. ama kendisi default public değildir.
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring - Kodun iyileştirilmesi