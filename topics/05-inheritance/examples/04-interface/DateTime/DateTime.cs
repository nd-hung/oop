/*
Minh họa đa thừa kế sử dụng giao diện.
*/

using System;

// Define Date interface
public interface IDate
{
    public int Day{get; set;}
    public int Month{get; set;}
    public int Year{get; set;}
}

// define Time interface
interface ITime
{
    public int Hour{get; set;}
    public int Minute{get; set;}
    public int Second{get; set;}
}

// define DateTime class deriving Date & Time interfaces
class DateTime: IDate, ITime
{
    public int Day{get; set;}
    public int Month{get; set;}
    public int Year{get; set;}
    public int Hour{get; set;}
    public int Minute{get; set;}
    public int Second{get; set;}

    // constructor
    public DateTime(int d, int month, int y, int h, int minute, int s)
    {
        Day = d;
        Month = month;
        Year = y;
        Hour = h;
        Minute = minute;
        Second = s;
    }

    public void Print()
    {
        Console.WriteLine("Current date/time is {0}/{1}/{2}-{3}:{4}:{5}", Day, Month, Year, Hour, Minute, Second);
    }
}

