using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;


        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public CarManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CarManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }
        public List<Color> Color.
    
    }
}
