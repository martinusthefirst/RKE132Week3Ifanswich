
int WeekDay = Convert.ToInt32 (DateTime.Now.DayOfWeek);

if (WeekDay == 0 )
{
    Console.WriteLine("Its Sunday");
}
else if (WeekDay == 1 )
{
    Console.WriteLine("Its Monday");
}
else if (WeekDay == 2 )
{
    Console.WriteLine("Its Tuesday");
}
else if (WeekDay == 3 )
{
    Console.WriteLine("Its Wednesday");
}
else if (WeekDay == 4 )
{
    Console.WriteLine("Its Thursday");
}
else if (WeekDay == 5 )
{
    Console.WriteLine("Its Friday");
}
else 
{ 
    Console.WriteLine("Its Saturday");
}

Console.WriteLine("Have a Nice day!!");