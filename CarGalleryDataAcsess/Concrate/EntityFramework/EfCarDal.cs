using CarGallery.Entites.Concrate;
using CarGalleryDataAcsess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalleryDataAcsess.Concrate.EntityFramework
{
    public class EfCarDal:EfRepositoryBase<Car,CarGalleryContext>,ICarDal
    {

    }
}
