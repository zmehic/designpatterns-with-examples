//using DesignPatterns.Decorator;
//using DesignPatterns.Factory.SimpleFactory;


//using DesignPatterns.Observer;
//using DesignPatterns.Strategy;
using DesignPatterns.Command.SimpleRemoteControl;
using DesignPatterns.Command.SimpleRemoteControl.CeilingFan;
using DesignPatterns.Command.SimpleRemoteControl.CeilingFan.Commands;
using DesignPatterns.Command.SimpleRemoteControl.Light;
using DesignPatterns.Command.SimpleRemoteControl.Light.Commands;
using DesignPatterns.Command.SimpleRemoteControl.Stereo;
using DesignPatterns.Command.SimpleRemoteControl.Stereo.Commands;
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

//Vehicle vehicle = new AudiA4();
//Console.WriteLine($"{vehicle.GetDescription()} - {vehicle.Cost()}");
//vehicle = new SunRoof(vehicle);
//vehicle = new SeatHeating(vehicle);
//Console.WriteLine($"{vehicle.GetDescription()} - {vehicle.Cost()}");

//Simple Factory

//PizzaStore pizzaStore = new PizzaStore();
//pizzaStore.OrderPizza(PizzaType.Capricciosa);

//Factory Method

//MostarPizzaStore mostarPizzaStore = new MostarPizzaStore();
//mostarPizzaStore.OrderPizza(PizzaType.Capricciosa);

//Logger logger = Logger.GetInstance();
//Logger logger2 = Logger.GetInstance();

//Console.WriteLine(logger.ToString());
//Console.WriteLine(logger2.ToString());

// Command Pattern

Light light = new Light();
Stereo stereo = new Stereo();
CeilingFan fan = new CeilingFan();

SimpleRemoteControl simpleRemote = new SimpleRemoteControl();
LightOnCommand lightOnCommand = new LightOnCommand(light);

simpleRemote.SetCommand(lightOnCommand);
simpleRemote.ButtonPress();

RemoteControl remoteControl = new RemoteControl();
StereoOnWithCdCommand stereoOnCommand = new StereoOnWithCdCommand(stereo);
StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);
LightOffCommand lightOffCommand = new LightOffCommand(light);

remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
remoteControl.SetCommand(1, stereoOnCommand, stereoOffCommand);

remoteControl.OnButtonPushed(0);
remoteControl.OnButtonPushed(1);
remoteControl.UndoButoonPushed();

remoteControl.OffButtonPushed(0);
remoteControl.OffButtonPushed(1);

CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(fan);
CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(fan);
CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(fan);

remoteControl.SetCommand(2, ceilingFanLowCommand, ceilingFanOffCommand);
remoteControl.SetCommand(3, ceilingFanHighCommand, ceilingFanOffCommand);

remoteControl.OnButtonPushed(2);
remoteControl.OnButtonPushed(3);
remoteControl.UndoButoonPushed();
remoteControl.UndoButoonPushed();

Command[] partyOn = { ceilingFanHighCommand, lightOnCommand, stereoOnCommand };
Command[] partyOff = {ceilingFanOffCommand, lightOffCommand, stereoOffCommand };

MacroCommand party = new MacroCommand(partyOn);
MacroCommand noParty = new MacroCommand(partyOff);


remoteControl.SetCommand(4, party, noParty);

remoteControl.OnButtonPushed(4);

