using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee's Time Keeping System");
            Console.WriteLine($"Current Date:  {DateTime.Today.ToShortDateString()}");

            Console.Write("Input your Name to login: ");
            string employeeId = Console.ReadLine();

            //Date and Time --> DateTime
            //Time only --> TimeSpan

            TimeSpan timeIn = new TimeSpan(8,0,0);
            Console.WriteLine($"Your login time is recorded: {timeIn}");

            Console.WriteLine("*********************************");
            Console.Write("Input your Name to logout: ");
            employeeId = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(11, 30, 0);
            Console.WriteLine($"Your logout time is recorded: {timeOut}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;

            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0,0,0);

            
            if (timeOut < regularHoursEnd)
            {
                 earlyOut = timeOut - regularHoursEnd;
                 Console.WriteLine($"{employeeId}'s total undertime hours is: {earlyOut}");
            }

            else{
              Console.WriteLine("You don't have any late keep up!");  
            }
        }
    }
}
