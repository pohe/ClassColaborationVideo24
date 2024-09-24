// See https://aka.ms/new-console-template for more information
using ClassColaborationVideo24;

Console.WriteLine("Hello, World!");


Wheel w1= new Wheel(2024, "Winter", 500);
Car c1 = new Car("Citroen", 5000, w1);
c1.Start();
Wheel w2= new Wheel(2024, "Summer", 550);
c1.ChangeWheel(w2);
double totalCo2 = c1.CalCo2Emission();
Console.WriteLine($"Total co2 udledning {totalCo2}   ");

Console.WriteLine("______________________________________________");
Console.WriteLine(c1.ToString());

