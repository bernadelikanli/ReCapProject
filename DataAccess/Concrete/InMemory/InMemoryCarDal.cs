using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=50000,ModelYear=2015,Description="Fiat"},
            new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=80000,ModelYear=2014,Description="Nissan"},
            new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=130000,ModelYear=2010,Description="Audi"},
            new Car{Id=4,BrandId=4,ColorId=6,DailyPrice=2500000,ModelYear=2017,Description="Alfa Romeo"},

            };

        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _Cars.SingleOrDefault(c=>c.Id==car.Id);
            _Cars.Remove(carToDelete);
                
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        
        public List<Car> GetByld(int Id)
        {
           return _Cars.Where(p => p.Id == Id).ToList();


        }

        public void Update(Car car)
        {
            Car carToUpdate = _Cars.SingleOrDefault(c => c.Id == car.Id);
            _Cars.Remove(carToUpdate);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;






        }
    }
}
