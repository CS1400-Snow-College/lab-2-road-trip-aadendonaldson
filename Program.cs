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
Console.Write("How many miles to get to" + location + "?");
Console.ReadLine();
string miles = Console.ReadLine()!;
int intmiles = Convert.ToInt32(miles);
Console.Write("Whats the average speed you will travel(MPH)?");
Console.ReadLine();
string speed = Console.ReadLine()!;
int intspeed = Convert.ToInt32(speed);
Console.Write("How many MPG does your car get?");
Console.ReadLine();
string MPG = Console.ReadLine()!;
int intMPG = Convert.ToInt32(MPG);
Console.Write("How many gallons of gas does your car hold?");
Console.ReadLine();
string gas = Console.ReadLine()!;
int intgas = Convert.ToInt32(gas);
Console.Write("Excluding your driver, how many riders are there?");
Console.ReadLine();
string riders = Console.ReadLine()!;
int intriders = Convert.ToInt32(riders);
Console.Write("What currency are you using (give the symbol)?");
Console.ReadLine();
string currency = Console.ReadLine()!;
Console.Write("What is the fuel price per gallon($)?");
Console.ReadLine();
string ppg = Console.ReadLine()!;
int intppg = Convert.ToInt32(ppg);

Console.Write("Driver: " + driver);
Console.Write("Currency: " + currency);

Console.Write("Distance (miles): " + intmiles);
Console.Write("Average Speed (mph): " + intspeed);
Console.Write("Time Driving: " + intmiles / intspeed + "H " + intmiles % intspeed + "M.");

Console.Write("Vehicle Miles per Gallon: " + intMPG);
Console.Write("Fuel Needed (round trip):" + intmiles / intMPG * 2 + " gallons");
Console.Write("Range per tank: " + intMPG * intgas);
Console.Write("Estimated fuel stops: " + (intmiles / intMPG * 2) / intMPG);

Console.Write("Gas Price per gallon: " + currency + intppg);
Console.Write("Fuel Cost: " + currency + (intmiles / intMPG * 2) * intppg);
Console.Write("Riders: " + (intriders + 1));
int intfuel = intmiles / intMPG * 2 * intppg ;
Console.Write("Cost per person: " + currency + intfuel / (intriders + 1) + "+ snacks");
Console.Write("Cost per mile: " + currency + intfuel / intmiles);
Console.Write("Cost per driving hour" + currency + intfuel / (intmiles / intspeed));

Console.Write("Average Song Length (min): 3 ");
Console.Write("Number of songs needed: " + (intmiles / intspeed) / 3.5);
