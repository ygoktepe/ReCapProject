using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 1800, Description = "Beyaz renkli Clio"},
                new Car{Id = 2, BrandId = 1, ColorId = 1, ModelYear = "2022", DailyPrice = 3000, Description = "Beyaz renkli Clio"},
                new Car{Id = 3, BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 3000, Description = "Siyah renkli Clio"},
                new Car{Id = 4, BrandId = 2, ColorId = 1, ModelYear = "2023", DailyPrice = 4000, Description = "Beyaz renkli Clio"},
                new Car{Id = 5, BrandId = 2, ColorId = 2, ModelYear = "2024", DailyPrice = 5000, Description = "Siyah renkli Clio"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
