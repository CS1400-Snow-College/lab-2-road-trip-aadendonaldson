// See https://aka.ms/new-console-template for more information
using System.Reflection;
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("We are going to map out a road trip for Fall Break. I'm going to ask you some specific questions abot the trip and then calculate a trip summery from that info.");
Console.Write("Where will you be driving?");
Console.ReadLine();
string location = Console.ReadLine()!;
Console.Write("Who will be driving?");
Console.ReadLine();
string driver = Console.ReadLine()!;
Console.Write("How many miles to get to your location?");
Console.ReadLine();
double distanceOneWay = double.Parse(Console.ReadLine()!);
Console.Write("Whats the average speed you will travel(MPH)?");
Console.ReadLine();
double speed = double.Parse(Console.ReadLine()!);
Console.Write("How many MPG does your car get?");
Console.ReadLine();
double mpg = double.Parse(Console.ReadLine()!);
Console.Write("How many gallons of gas does your car hold?");
Console.ReadLine();
double gasCarHolds = double.Parse(Console.ReadLine()!);
Console.Write("Excluding your driver, how many riders are there?");
Console.ReadLine();
double ridersMinusDriver = double.Parse(Console.ReadLine()!);
Console.Write("What currency are you using (give the symbol)?");
Console.ReadLine();
string currency = Console.ReadLine()!;
Console.Write("What is the fuel price per gallon($)?");
Console.ReadLine();
double priceOfFuel = double.Parse(Console.ReadLine()!);

//The Calculations
double fullTripDistance = distanceOneWay * 2;
double timeSpentDriving = distanceOneWay / speed;
double hours = (double)timeSpentDriving;
double minutes = (double)((timeSpentDriving - hours) * 60);

double fuelNeeded = fullTripDistance / mpg;
double distencePerTank = mpg * gasCarHolds;
double stopsForFuel = (double)Math.Ceiling(fullTripDistance / distencePerTank);

double fuelCostTotal = fuelNeeded * priceOfFuel;
double allTheBeings = ridersMinusDriver + 1;
double costPerPerson = fuelCostTotal / allTheBeings;
double costPerMile = fuelCostTotal / fullTripDistance;
double costPerHour = fuelCostTotal / timeSpentDriving;

double songLength = 3.5;
double numberOfSongs = (double)Math.Round(timeSpentDriving * 60) / songLength;


// The Details

Console.WriteLine("Driver: " + driver);
Console.WriteLine("Currency: " + currency);

Console.WriteLine("Distance (miles): " + fullTripDistance);
Console.WriteLine("Average Speed (mph): " + speed);
Console.WriteLine("Time Driving: " + hours + "H " + minutes + "M.");

Console.WriteLine("Vehicle Miles per Gallon: " + mpg);
Console.WriteLine("Fuel Needed (round trip):" + fuelNeeded + " gallons");
Console.WriteLine("Range per tank: " + distencePerTank);
Console.WriteLine("Estimated fuel stops: " + stopsForFuel);

Console.WriteLine("Gas Price per gallon: " + currency + priceOfFuel);
Console.WriteLine("Fuel Cost: " + currency + fuelCostTotal);
Console.WriteLine("Riders: " + allTheBeings);
Console.WriteLine("Cost per person: " + currency + costPerPerson + "+ snacks");
Console.WriteLine("Cost per mile: " + currency + costPerMile);
Console.WriteLine("Cost per driving hour" + currency + costPerHour);

Console.WriteLine("Average Song Length (min):" + songLength);
Console.WriteLine("Number of songs needed:" + numberOfSongs );


