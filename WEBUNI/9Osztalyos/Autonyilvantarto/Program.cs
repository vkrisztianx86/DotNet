using Autonyilvantarto;

Auto a1 = new Auto("abc-123", AutoEnum.Fiat);
Auto a2 = new Auto("cdc-121", AutoEnum.Ford);

a1.Megy(2.1);
a1.Megy(2.3);
a2.Megy(8.2);

Console.WriteLine(a1.AtlagFogy());
Console.WriteLine(a2.AtlagFogy());

Console.WriteLine(Auto.Allomany());