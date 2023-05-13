int WeekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);// väärtus on vahemikus 0-6

switch (WeekDay)// väärtus mida kontrollitakse
{
    case 0: // case 0: == if (weekDay== 0)
        Console.WriteLine("Its Sunday");
        break;
case 1: Console.WriteLine("Its Monday");
            break;
        case 2: Console.WriteLine("Its Tuesday");
        break;
        case 3: Console.WriteLine("Its Wednesday");
        break;
     case 4: Console.WriteLine("Its Thursday");
        break;
    case 5:Console.WriteLine("Its Friday");
        break;
    case 6:Console.WriteLine("Its saturday");
        break;
        default: Console.WriteLine("Oops, Your calender is broken");
        break;
        
}

Console.WriteLine("Have Nice day")