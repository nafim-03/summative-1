// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Car hire charge calculator");

long days = Convert.ToInt64(Console.ReadLine());
long days_hired_for = days * 25;

Console.WriteLine("How much fuel was left in the tank?");
float fuel_left = float.Parse(Console.ReadLine());
Console.WriteLine($"{fuel_left} litre(s) fuel left");
float petrol_used = 50 - fuel_left;
double charge_fee_of_fuel = petrol_used * 2.5;

double overall_cost = (days_hired_for + charge_fee_of_fuel + 10); // £10 booking fee
Console.WriteLine($"The total charge for the car hire would be £ {overall_cost}");
