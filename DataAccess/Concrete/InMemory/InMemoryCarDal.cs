using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1,BrandId = 1, ColorId = 1,DailyPrice = 700,Description = "vehicle 1"},
                new Car { Id = 2,BrandId = 2, ColorId = 1,DailyPrice = 400,Description = "vehicle 2"},
                new Car { Id = 3,BrandId = 2, ColorId = 2,DailyPrice = 800,Description = "vehicle 3"},
                new Car { Id = 4,BrandId = 1, ColorId = 3,DailyPrice = 1500,Description = "vehicle 4"},
                new Car { Id = 5,BrandId = 1, ColorId = 2,DailyPrice = 3000,Description = "vehicle 5"},
                new Car { Id = 6,BrandId = 3, ColorId = 2,DailyPrice = 1000,Description = "vehicle 6"},
                new Car { Id = 7,BrandId = 2, ColorId = 1,DailyPrice = 1400,Description = "vehicle 7"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id ).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
