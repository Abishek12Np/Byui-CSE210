using System;
class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity type
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2022, 11, 3), 30, 20);
        Activity swimming = new Swimming(new DateTime(2022, 11, 3), 30, 10);

        // Put each activity in the same list
        Activity[] activities = { running, cycling, swimming };

        // Iterate through the list and call GetSummary method on each item
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
