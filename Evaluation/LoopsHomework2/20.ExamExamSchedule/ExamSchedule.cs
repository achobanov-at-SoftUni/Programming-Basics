using System;

class ExamSchedule
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        int start = hours % 12;
        if (partOfDay == "PM")
        {
            start += 12;
        }

        DateTime startTime = new DateTime(2015, 06, 22, start, minutes, 0);
        startTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);
        Console.WriteLine("{0:hh:mm:tt}", startTime);
    }
}

