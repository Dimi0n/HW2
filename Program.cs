Задача 10. Показывает 2 цифру.
 Console.Write("Введи трёхзначное число: ");
 string myNumber = Console.ReadLine();
 Console.WriteLine("вторая цифра этого числа -> "+myNumber[1]);

 
Задача 13. Показывает 3 цифру или сообщает, что ее нет.
Console.Write("Введи число: ");
string Number = Console.ReadLine();
if (Number.Length > 2)
{
  Console.WriteLine("третья цифра -> " + Number[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}
 
//Задача 15. Дни недели
Console.WriteLine("Введите число: ");
string i = Console.ReadLine();

switch (i)
{
    case "1":
    Console.WriteLine("Вы ввели 1 - это понедельник. Рабочий день (тяжелый)");
    break;

    case "2":
    Console.WriteLine("Вы ввели 2 - это вторник. Рабочий день");
    break;

    case "3":
    Console.WriteLine("Вы ввели 3 - это среда. Рабочий день");
    break;

    case "4":
    Console.WriteLine("Вы ввели 4 - это четверг. Рабочий день");
    break;

    case "5":
    Console.WriteLine("Вы ввели 5 - это пятница. Не очень рабочий день :))");
    break;

    case "6":
    Console.WriteLine("Вы ввели 6 - это суббота. НЕ рабочий день");
    break;

    case "7":
    Console.WriteLine("Вы ввели 7 - это воскресенье. НЕ рабочий день");
    break;
    default:
    System.Console.WriteLine("Дня недели с таким номером не существует!");
    break;
  
}
