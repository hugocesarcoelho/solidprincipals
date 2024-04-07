using OpenClosedPrinciple.Before.Interface;
using OpenClosedPrinciple.Before.Model;

namespace OpenClosedPrinciple.Before
{
    public class CarService : ICarService
    {
        public Car BuildCar(string carType)
        {
            var result = new Car();
            switch (carType)
            {
                case "truck":
                    result = new Car
                    {
                        Transmission = "manual",
                        HeightCentimeters = 200,
                        WidthCentimeters = 350,
                        NumberOfDoors = 2
                    };
                    break;
                case "sedan":
                    result = new Car
                    {
                        Transmission = "automatic",
                        HeightCentimeters = 150,
                        WidthCentimeters = 300,
                        NumberOfDoors = 4
                    };
                    break;
                case "hatch":
                    result = new Car
                    {
                        Transmission = "manual",
                        HeightCentimeters = 150,
                        WidthCentimeters = 280,
                        NumberOfDoors = 2
                    };
                    break;
            }
            return result;
        }
    }
}
