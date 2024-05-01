// See https://aka.ms/new-console-template for more information

using LeapYear;

var leap = new Leap();
var leaps = leap.Leaps(1900, 2000);
Console.WriteLine(string.Join(", ", leaps));