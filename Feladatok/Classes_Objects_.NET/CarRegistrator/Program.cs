using CarRegistrator;

Car a1 = new Car("hzv-242", CarEnum.Fiat);
Car a2 = new Car("lpt-425", CarEnum.Ford);

a1.Go(2.5);
a1.Go(3.4);
a2.Go(9.5);
a2.Go(7.5);


Console.WriteLine(a1.AvgConsumption());
Console.WriteLine(a2.AvgConsumption());

Console.WriteLine(Car.AllCar());
Console.WriteLine(a1.amortization);
Console.WriteLine(a2.amortization);
