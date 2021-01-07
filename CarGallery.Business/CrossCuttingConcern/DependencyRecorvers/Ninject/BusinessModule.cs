using CarGallery.Business.Abstract;
using CarGallery.Business.Concrate;
using CarGalleryDataAcsess.Abstract;
using CarGalleryDataAcsess.Concrate.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGallery.Business.CrossCuttingConcern.DependencyRecorvers.Ninject
{
    class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDal>().To<EfCarDal>().InSingletonScope();
        }
    }
}
