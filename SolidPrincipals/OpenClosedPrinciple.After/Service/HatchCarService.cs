using OpenClosedPrinciple.Before.Interface;
using OpenClosedPrinciple.Before.Model;

namespace OpenClosedPrinciple.After.Service
{
    public class HatchCarService : ICarService
    {
        public Car BuildCar()
        {
            return new Car
            {
                Transmission = "manual",
                HeightCentimeters = 150,
                WidthCentimeters = 280,
                NumberOfDoors = 2
            };
        }
    }
}
