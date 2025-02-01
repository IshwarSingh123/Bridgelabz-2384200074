/*1. Problem 1: Time Zones and DateTimeOffset
Write a program that displays the current time in different time zones:
● GMT (Greenwich Mean Time)
● IST (Indian Standard Time)
● PST (Pacific Standard Time)
Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.*/
using System;

class TimeZone
{
	public static void Main()
	{
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		
		TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtZone);
        Console.WriteLine("GMT: " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));
		
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
	    DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
		Console.WriteLine("IST: " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));
		
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
		DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
        Console.WriteLine("PST: " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
		
		// TimeZoneInfo romanceZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
		// DateTimeOffset romanceTime = TimeZoneInfo.ConvertTime(utcNow,Zone);
		// Console.WriteLine("Romance Time: "+romanceTime.ToString("yyyy-MM-dd HH:mm:ss"));
		
		
	}
}
