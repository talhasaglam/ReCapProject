using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(),new EfBrandDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.DailyPrice+ "  " +car.ModelYear +" " + car.Description );
            }
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new EfBrandDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.DailyPrice + "  " + car.ModelYear + " " + car.Description +" " + car.ColorName + " " + car.BrandName);
            }
        }

        private static void CarTest3()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new EfBrandDal());

            Car car = new Car();

            car.Description = "ass";
            car.DailyPrice = 0;

            Console.WriteLine( carManager.Add(car).Message + " " + carManager.Add(car).Success);

 
        }

        private static void CarTest4()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new EfBrandDal());

            var result = carManager.GetCarDetails();

            if(result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void Add()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            CustomerManager  customerManager= new CustomerManager(new EfCustomerDal());

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rental = new Rental();
            User user2 = new User();
            Customer customer = new Customer();


                customerManager.Add(customer);

           // Console.WriteLine(userManager.Add(user2).Message);


        }
    }
}
