using System;

class Program
{
    static void Main(string[] args)
    {
        // NOTE: Sorry if the code isn't up to par, as you might remember, I wasn't able to complete
        // the assignment for Develop05. As such, I had to research a lot of this information.
        // Also, I struggled to understand the expectations of the assignment? I followed what I
        // BELIEVE it was asking for...
        // Thank you for a great year!
        List<Activity> _activities = new List<Activity>
        {
            new Running(new DateTime(2025, 4, 7), 30, 3.0),
            new Bicycles(new DateTime(2025, 4, 7), 30, 10.5),
            new Swimming(new DateTime(2025, 4, 7), 30, 50)
        };

        foreach (Activity activity in _activities)
        {
            activity.GetSummary();
        }
    }
}