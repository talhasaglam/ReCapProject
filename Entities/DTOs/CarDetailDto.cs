using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto: IDto
    {

        public int Id { get; set; }

        public string BrandName { get; set; } //Marka

        public string ColorName { get; set; }

        public int ModelYear { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }

    }
}
