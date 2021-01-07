using CarGallery.Business.Abstract;
using CarGallery.Entites.Concrate;
using CarGalleryDataAcsess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarGallery.Business.Concrate
{
    public class CarManager : ICarService
    {
        private ICarDal _car;

        public CarManager(ICarDal car)
        {
            _car = car;
        }

        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            _car.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _car.Get(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car.GetAll(filter);
        }

        public void Update(Car entity)
        {
            _car.Update(entity);
        }
    }
}
