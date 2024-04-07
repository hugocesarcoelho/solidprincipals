using OpenClosedPrinciple.Before.Interface;
using OpenClosedPrinciple.Before.Model;

namespace OpenClosedPrinciple.After.Service
{
    public class TruckCarService : ICarService
    {
        public Car BuildCar()
        {
            return new Car
            {
                Transmission = "manual",
                HeightCentimeters = 200,
                WidthCentimeters = 350,
                NumberOfDoors = 2
            };
        }
    }
}
