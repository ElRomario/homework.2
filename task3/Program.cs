


bool dayfOfTheWeek(int day)
{
    
    switch(day)
    {
        case 1: return false;break;
        case 2: return false;break;
        case 3: return false;break;
        case 4: return false;break;
        case 5: return false;break;
        case 6: return true;break;
        case 7: return true;break;
        default: return false;
    }
    return false;
}

Console.WriteLine("Введите номер дня недели:");
int day = int.Parse(Console.ReadLine());

if(dayfOfTheWeek(day)) Console.WriteLine($"{day}й день является выходным");
else Console.WriteLine($"{day}й день не является выходным");



