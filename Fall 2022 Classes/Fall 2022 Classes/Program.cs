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