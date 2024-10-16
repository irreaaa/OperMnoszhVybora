using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Введите количество месяцев с начала 1990 года: ");
string months = Console.ReadLine();
try
{
    int month = Convert.ToInt32(months);

    int monthDet = (month%12) + 1;

    int year = 1990 + (month / 12);
    

    int a = (2 + ((31 * monthDet) / 12) + year + (year / 4) - (year / 100) + (year / 400)); ;
    if (monthDet == 1 )
    {

    }
    else
    {
        a = (2 + ((31 *  monthDet)/12) + year + (year/4) - (year/100) + (year/400));
    }

    int dayNed = a % 7;

    string textDayNed = "День недели: ";
    
    switch (dayNed)
    {
        case 0: Console.WriteLine(textDayNed + "воскресенье"); break;
        case 1: Console.WriteLine(textDayNed + "понедельник"); break;
        case 2: Console.WriteLine(textDayNed + "вторник"); break;
        case 4: Console.WriteLine(textDayNed + "среда"); break;
        case 5: Console.WriteLine(textDayNed + "четверг"); break;
        case 6: Console.WriteLine(textDayNed + "пятница"); break;
        case 7: Console.WriteLine(textDayNed + "воскресенье"); break;
    }



    string textMonth = "Месяц: ";
    switch (monthDet)
    {
        case 1: Console.WriteLine(textMonth + "январь"); break;
        case 2: Console.WriteLine(textMonth + "февраль"); break;
        case 3: Console.WriteLine(textMonth + "март"); break;
        case 4: Console.WriteLine(textMonth + "апрель"); break;
        case 5: Console.WriteLine(textMonth + "май"); break;
        case 6: Console.WriteLine(textMonth + "июнь"); break;
        case 7: Console.WriteLine(textMonth + "июль"); break;
        case 8: Console.WriteLine(textMonth + "август"); break;
        case 9: Console.WriteLine(textMonth + "сентябрь"); break;
        case 10: Console.WriteLine(textMonth + "октябрь"); break;
        case 11: Console.WriteLine(textMonth + "ноябрь"); break;
        case 12: Console.WriteLine(textMonth + "декабрь"); break;
    }


    Console.Write(year);


    DateTime.IsLeapYear(year);
    if (DateTime.IsLeapYear(year) == true)
    {
        Console.WriteLine(" год високосный");
    }
    else { };

}
catch (Exception e) { Console.WriteLine("Некорректный ввод"); }

Console.ReadKey();