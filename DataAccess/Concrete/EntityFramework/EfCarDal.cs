using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands 
                             on p.BrandId equals c.Id
                             join e in context.Colors
                             on p.ColorId equals e.Id
                             select new CarDetailDto
                             {
                                 Id = p.Id,
                                 BrandName = c.Name,
                                 ColorName = e.Name,
                                 ModelYear = p.ModelYear,
                                 Description = p.Description,
                                 DailyPrice= p.DailyPrice
                             };
                return result.ToList();

    }

}
    }
}
