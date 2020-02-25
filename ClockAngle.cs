using System;

public class ClockAngle
{
  public static int Time(int hour, int minute)
  {
  Console.WriteLine(hour + ":" + minute);
  int minuteDegree = (minute * 6);
  int hourDegree = ((hour * 30) + (minuteDegree / 360));
  int difference = (hourDegree - minuteDegree);
  if ((difference <= 180) && (difference >=0))
  {
    return difference;
  }
  else
  {
    int answer = (360 - difference);
    return answer;
  }
}

  public static void Main()
  {
    Console.WriteLine("What is the current hour?");
    string getUserHour = Console.ReadLine();
    int hour = int.Parse(getUserHour);

    Console.WriteLine("What is the current minute?");
    string getUserMinute = Console.ReadLine();
    int minute = int.Parse(getUserMinute);
    int result = Time(hour, minute);
    Console.WriteLine(result);
  }
}
