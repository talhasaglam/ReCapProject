using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {

        //Dtolar için de yazıyoz.
        public CarValidator()
        {
     
            //Fluent Validatoru araştır ona göre kullanıcaksın...
            //İstersek tek satırda da yazabiliriz.
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            //Cat id 1 olduğunda unitprice10 olmalı..
           // RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.BrandId == 1);
            //RuleFor(p => p.ProductName).Must(StartwithA).WithMessage("Ürünler A ile başlasın."); //StartwithA methodunu sen yazcacaksın, with message ile de yazabiliriz.
        }

        //private bool StartwithA(string arg)
        //{
        //    return arg.StartsWith("A"); //C# İÇİNDEKİ string fonksiyonu başarılı ise true döner zaten.
        //}

    }
}
