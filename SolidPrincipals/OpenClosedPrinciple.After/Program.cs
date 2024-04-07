using OpenClosedPrinciple.After.Service;

var truck = new TruckCarService().BuildCar();
Console.WriteLine(
    $"The truck has {truck.NumberOfDoors} doors, the transmission is {truck.Transmission} " +
    $"and it is {truck.HeightCentimeters} by {truck.WidthCentimeters} centimeters");

var sedan = new SedanCarService().BuildCar();
Console.WriteLine(
    $"The sedan has {sedan.NumberOfDoors} doors, the transmission is {sedan.Transmission} " +
    $"and it is {sedan.HeightCentimeters} by {sedan.WidthCentimeters} centimeters");

var hatch = new HatchCarService().BuildCar();
Console.WriteLine(
    $"The hatch has {sedan.NumberOfDoors} doors, the transmission is {hatch.Transmission} " +
    $"and it is {hatch.HeightCentimeters} by {hatch.WidthCentimeters} centimeters");