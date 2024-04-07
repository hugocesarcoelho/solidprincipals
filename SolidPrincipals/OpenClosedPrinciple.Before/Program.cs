using OpenClosedPrinciple.Before;

var carService = new CarService();

var truck = carService.BuildCar("truck");
Console.WriteLine(
    $"The truck has {truck.NumberOfDoors} doors, the transmission is {truck.Transmission} " +
    $"and it is {truck.HeightCentimeters} by {truck.WidthCentimeters} centimeters");

var sedan = carService.BuildCar("sedan");
Console.WriteLine(
    $"The sedan has {sedan.NumberOfDoors} doors, the transmission is {sedan.Transmission} " +
    $"and it is {sedan.HeightCentimeters} by {sedan.WidthCentimeters} centimeters");

var hatch = carService.BuildCar("hatch");
Console.WriteLine(
    $"The hatch has {sedan.NumberOfDoors} doors, the transmission is {hatch.Transmission} " +
    $"and it is {hatch.HeightCentimeters} by {hatch.WidthCentimeters} centimeters");