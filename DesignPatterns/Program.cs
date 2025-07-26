using DesignPatterns.Decorator;
//using DesignPatterns.Observer;
//using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Consumption;

// Strategy

//Vehicle car = new Car();

//car.CheckConsumption();
//car.CheckSounding();
//car.Color();

//car.consumption = new Electricity();

//car.CheckConsumption();

// Observer

//BloodPressureData bloodPressureData = new BloodPressureData();

//LifeSupportMonitor lifeSupportMonitor = new LifeSupportMonitor(bloodPressureData);
//BloodPressureMonitor bloodPressureMonitor = new BloodPressureMonitor(bloodPressureData);

//bloodPressureData.UpdateDate(100, 120, 80);
//bloodPressureData.UpdateDate(80, 100, 90);
//bloodPressureData.UpdateDate(50, 130, 60);
//bloodPressureData.UpdateDate(75, 90, 50);

//bloodPressureData.UnregisterObserver(lifeSupportMonitor);

//bloodPressureData.UpdateDate(150, 90, 20);
//bloodPressureData.UpdateDate(175, 90, 50);

// Decorator

Vehicle vehicle = new AudiA4();
Console.WriteLine($"{vehicle.GetDescription()} - {vehicle.Cost()}");
vehicle = new SunRoof(vehicle);
vehicle = new SeatHeating(vehicle);
Console.WriteLine($"{vehicle.GetDescription()} - {vehicle.Cost()}");
