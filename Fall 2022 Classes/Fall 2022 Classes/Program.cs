using Fall_2022_Classes;

// creating a car with our default constructor
Car ashleysCar = new Car();
Console.WriteLine("Ashley has a " + ashleysCar.Make);

Console.WriteLine(ashleysCar.Make);

ashleysCar.IsPayedFor = true;
Console.WriteLine("This car is paid for? " + ashleysCar.IsPayedFor);

// creating another car with a different constructor
Car gavinsCar = new Car("Toyota","Camry","Grey", 2007, 0, true);

Console.WriteLine("Gavin has a " + gavinsCar.Make);

// making a list of objects from new class
var garage = new List<Car>();

// adding our cars to the list
garage.Add(ashleysCar);
garage.Add(gavinsCar);

// showing we can access those cars and our properties from the list
Console.WriteLine(garage[1].Model);

// see the effects of the Accelerate method
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate();
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate();
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate(7);
Console.WriteLine(gavinsCar.Speed);

// referencing a static method
// class.name
// Note this only works by calling the class, not an object

Car.Honk();
var timeToDrive = gavinsCar.TimeToTravelDistance(500);
Console.WriteLine(timeToDrive);

// gavinsCar.TimeToTravelDistance(500) alone is a complete statement, you must do something with it like print to the Console
