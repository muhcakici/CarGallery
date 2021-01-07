using CarGallery.Business.Abstract;
using CarGallery.Business.CrossCuttingConcern.DependencyRecorvers.Ninject;
using System;

namespace CarGallery.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carService = InstanceFactory.Get<ICarService>();
            var list = carService.GetAll();
            foreach (var c in list)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
