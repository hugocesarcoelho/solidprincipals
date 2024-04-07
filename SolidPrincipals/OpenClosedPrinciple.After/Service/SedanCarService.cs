using OpenClosedPrinciple.Before.Interface;
using OpenClosedPrinciple.Before.Model;

namespace OpenClosedPrinciple.After.Service
{
    public class SedanCarService : ICarService
    {
        public Car BuildCar()
        {
            return new Car
            {
                Transmission = "automatic",
                HeightCentimeters = 150,
                WidthCentimeters = 300,
                NumberOfDoors = 4
            };
        }
    }
}
